import { Component, inject, Input, OnInit, signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TableLazyLoadEvent } from 'primeng/table';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Title } from '@angular/platform-browser';
import { FORM_IMPORTS } from '@/app/core/shared/imports/form-imports/form-imports.imports';
import { DATA_IMPORTS } from '@/app/core/shared/imports/data-imports/data-imports';
import { environment } from '@/app/core/environments/environment';
import { UserService } from '@/app/core/services/user.services';
import { StorageService } from '@/app/core/services/storage.service';
import { UserSession } from '@/app/core/models/user.model';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-menu',
    standalone: true,
    imports: [...FORM_IMPORTS, ...DATA_IMPORTS],
    providers: [MessageService, ConfirmationService],
    templateUrl: './user.component.html',
    styleUrl: './user.component.scss'
})
export class Users {    
    title: string | null = null;
    private route = inject(ActivatedRoute);
    private readonly pagination = environment.pagination;
    private readonly titleService = inject(Title);
    private readonly messageService = inject(MessageService);
    private readonly confirmationService = inject(ConfirmationService);
    private readonly userService = inject(UserService);
    private readonly storageService = inject(StorageService);
    private readonly fb = inject(FormBuilder);
    public readonly user = signal<UserSession>({username: '',role: ''});
    ngOnInit() {
        this.titleService.setTitle('User | ECB Technology Assignment');
        this.title = this.route.snapshot.paramMap.get('title');
        const role = this.storageService.getItem('USER_ROLE');
        if (role) {
            this.user.update((currentUser) => ({
                ...(currentUser || {}),
                role: role
            }));
        } 
        if(role=='Authorizer')
        this.loadDocuments(1,10,'Checked')
    }
    searchTerm: string = '';
    totalRecords = signal<number>(0);
    pageSize = signal<number>(this.pagination.pageSize);
    first = signal<number>(this.pagination.first);
    documents = signal<any[]>([]);
    loading = signal<boolean>(false);
    rowsPerPageOptions = signal<number[]>(this.pagination.rowsPerPageOptions);
    configDialogVisible = signal<boolean>(false);
    configViewDialogVisible = signal<boolean>(false);
    saving = signal<boolean>(false);
    isEditMode = signal<boolean>(false);
    submitted = signal<boolean>(false);
    selectedAuthorizer = signal<any>(null);
    authorizerForm: FormGroup = this.fb.group({
        id: [null],
        title: ['', Validators.required],
        content: ['', Validators.required]
    });

    loadDocuments(pageNumber: number = 1, pageSize: number = 10, searchTerm: string = ''): void {
        this.loading.set(true);
        this.userService.getAll({ pageNumber, pageSize, searchTerm }).subscribe({
            next: (response: any) => {
                console.log(response);
                this.documents.set(response.data || []);
                this.totalRecords.set(response.totalCount || 0);
                this.loading.set(false);
            },
            error: (err) => {
                this.loading.set(false);
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to load data' });
            }
        });
    }
    onLazyLoad(event: TableLazyLoadEvent): void {
        const pageNumber = (event.first ?? 0) / (event.rows ?? 10) + 1;
        const pageSize = event.rows ?? 10;
        this.pageSize.set(pageSize);
        this.first.set(event.first ?? 0);
        this.loadDocuments(pageNumber, pageSize, this.searchTerm);
    }
    openNew(): void {
        this.isEditMode.set(false);
        this.submitted.set(false);
        this.authorizerForm.reset();
        this.configDialogVisible.set(true);
    }

    editDocument(document: any): void {
        this.isEditMode.set(true);
        this.submitted.set(false);
        this.authorizerForm.patchValue({
            id: document.id,
            title: document.title,
            content: document.content,
            status: document.status
        });
        this.configDialogVisible.set(true);
    }

    viewDocument(document: any): void {
        this.selectedAuthorizer.set(document);
        this.configViewDialogVisible.set(true);
    }

    deleteDocument(authorizer: any): void {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete this Authorizer?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.userService.delete(authorizer.id).subscribe({
                    next: (value: boolean) => {
                        if (value) {
                            this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Config Deleted', life: 3000 });
                            this.loadDocuments(this.first() / this.pageSize() + 1, this.pageSize(), this.searchTerm);
                        } else {
                            this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to delete config' });
                        }
                    },
                    error: (err) => {
                        this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to delete config' });
                    }
                });
            }
        });
    }

    saveDocument(): void {
        this.submitted.set(true);
        if (this.authorizerForm.invalid) {
            return;
        }

        this.saving.set(true);
        const formData = this.authorizerForm.value;
        const request$ = this.isEditMode() ? this.userService.update(formData.id, formData) : this.userService.create(formData);

        request$.subscribe({
            next: (value: any) => {
                this.messageService.add({
                    severity: 'success',
                    summary: 'Successful',
                    detail: this.isEditMode() ? 'data Updated' : 'data Saved',
                    life: 3000
                });
                this.loadDocuments(this.first() / this.pageSize() + 1, this.pageSize(), this.searchTerm);
                this.submitted.set(false);
                this.saving.set(false);
                this.configDialogVisible.set(false);
            },
            error: (err: any) => {
                this.saving.set(false);
                this.messageService.add({
                    severity: 'error',
                    summary: 'Error',
                    detail: this.isEditMode() ? 'Failed to update data' : 'Failed to save data'
                });
            }
        });
    }

    searchAuthorizers(): void {
        this.first.set(0);
        this.loadDocuments(1, this.pageSize(), this.searchTerm);
    }

    hideDialog(): void {
        this.configDialogVisible.set(false);
        this.submitted.set(false);
    }

    hideViewDialog(): void {
        this.configViewDialogVisible.set(false);
        this.selectedAuthorizer.set(null);
    }

    onConfigDialogVisibleChange(visible: boolean): void {
        this.configDialogVisible.set(visible);
    }

    onViewDialogVisibleChange(visible: boolean): void {
        this.configViewDialogVisible.set(visible);
    }
}
