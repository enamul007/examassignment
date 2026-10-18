import { ActivatedRoute, RouterModule } from '@angular/router';
import { Component, inject, Input, OnInit, signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { TableModule, TableLazyLoadEvent } from 'primeng/table';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Title } from '@angular/platform-browser';
import { FORM_IMPORTS } from '@/app/core/shared/imports/form-imports/form-imports.imports';
import { DATA_IMPORTS } from '@/app/core/shared/imports/data-imports/data-imports';
import { environment } from '@/app/core/environments/environment';
import { CheckerService } from '@/app/core/services/checker.services';

//--------------

@Component({
    selector: 'app-checker',
    standalone: true,
    imports: [...FORM_IMPORTS, ...DATA_IMPORTS],
    providers: [MessageService, ConfirmationService],
    templateUrl: './checker.component.html',
    styleUrl: './checker.component.scss'
})
export class Checkers {
    private readonly router = inject(Router);
    title: string | null = null;
    private route = inject(ActivatedRoute);
    private readonly pagination = environment.pagination;
    private readonly titleService = inject(Title);
    private readonly messageService = inject(MessageService);
    private readonly confirmationService = inject(ConfirmationService);
    private readonly checkerService = inject(CheckerService);
    private readonly fb = inject(FormBuilder);
    ngOnInit() {
        this.titleService.setTitle('Checker | ECB Technology Assignment');
        this.title = this.route.snapshot.paramMap.get('title');
    }
    searchTerm: string = '';
    totalRecords = signal<number>(0);
    pageSize = signal<number>(this.pagination.pageSize);
    first = signal<number>(this.pagination.first);
    authorizers = signal<any[]>([]);
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
        content: ['', Validators.required],
        status: ['', Validators.required]
    });

    loadAuthorizers(pageNumber: number = 1, pageSize: number = 10, searchTerm: string = ''): void {
        this.loading.set(true);
        this.checkerService.getAll({ pageNumber, pageSize, searchTerm }).subscribe({
            next: (response: any) => {
                console.log(response);
                this.authorizers.set(response.data || []);
                this.totalRecords.set(response.totalCount || 0);
                this.loading.set(false);
            },
            error: (err) => {
                this.loading.set(false);
                this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Failed to load configs' });
            }
        });
    }
    onLazyLoad(event: TableLazyLoadEvent): void {
        const pageNumber = (event.first ?? 0) / (event.rows ?? 10) + 1;
        const pageSize = event.rows ?? 10;
        this.pageSize.set(pageSize);
        this.first.set(event.first ?? 0);
        this.loadAuthorizers(pageNumber, pageSize, this.searchTerm);
    }
    GoTodashboard(): void {
         this.router.navigate(['/documents']);
    }

    editConfig(authorizer: any): void {
        this.isEditMode.set(true);
        this.submitted.set(false);
        this.authorizerForm.patchValue({
            id: authorizer.id,
            title: authorizer.title,
            content: authorizer.content,
            status: authorizer.status
        });
        this.configDialogVisible.set(true);
    }

    viewAuthorizer(authorizer: any): void {
        this.selectedAuthorizer.set(authorizer);
        this.configViewDialogVisible.set(true);
    }

    deleteAuthorizer(authorizer: any): void {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete this Authorizer?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.checkerService.delete(authorizer.id).subscribe({
                    next: (value: boolean) => {
                        if (value) {
                            this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Config Deleted', life: 3000 });
                            this.loadAuthorizers(this.first() / this.pageSize() + 1, this.pageSize(), this.searchTerm);
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

    saveAuthorizer(): void {
        this.submitted.set(true);
        if (this.authorizerForm.invalid) {
            return;
        }

        this.saving.set(true);
        const formData = this.authorizerForm.value;
        const request$ = this.isEditMode() ? this.checkerService.update(formData.id, formData) : this.checkerService.create(formData);

        request$.subscribe({
            next: (value: any) => {
                this.messageService.add({
                    severity: 'success',
                    summary: 'Successful',
                    detail: this.isEditMode() ? 'Config Updated' : 'Config Saved',
                    life: 3000
                });
                this.loadAuthorizers(this.first() / this.pageSize() + 1, this.pageSize(), this.searchTerm);
                this.submitted.set(false);
                this.saving.set(false);
                this.configDialogVisible.set(false);
            },
            error: (err: any) => {
                this.saving.set(false);
                this.messageService.add({
                    severity: 'error',
                    summary: 'Error',
                    detail: this.isEditMode() ? 'Failed to update config' : 'Failed to save config'
                });
            }
        });
    }

    searchAuthorizers(): void {
        this.first.set(0);
        this.loadAuthorizers(1, this.pageSize(), this.searchTerm);
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
