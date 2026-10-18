import { AuthService } from '@/app/core/services/auth/auth.service';
import { FORM_IMPORTS } from '@/app/core/shared/imports/form-imports/form-imports.imports';
import { Component, inject, signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
    selector: 'app-login',
    standalone: true,
    imports: [...FORM_IMPORTS],
    templateUrl: './login.component.html',
    styleUrl: './login.component.scss'
})
export class LoginComponent {
    /*dependencies */
    private fb = inject(FormBuilder);
    private readonly router = inject(Router);
    private authService = inject(AuthService);
    constructor() {
        this.loginForm = this.fb.group({
            username: ['', [Validators.required]],
            password: ['', [Validators.required, Validators.minLength(6)]],
            rememberMe: [false]
        });
    }
    loginForm!: FormGroup;
    systemname = signal<string>('ECB Technology Assignment!');
   onSubmit() {
    if (this.loginForm.valid) {
        this.authService.login(this.loginForm.value).subscribe({
            next: (response) => {
                console.log('Login successful!', response);

                let routePath = '';
                switch (response.role) {
                    case 'User':
                        routePath = '/documents';
                        break;
                    case 'Checker':
                        routePath = '/checker';
                        break;
                    case 'Authorizer':
                        routePath = '/authorizer';
                        break;
                    default:
                        routePath = '/auth/login';
                        break;
                }
                const title = `This is ${response.role} Page`;
                if(response.role==='User'){
                this.router.navigate([routePath]);
                }else{
                    this.router.navigate([routePath, title]);
                }
            },
            error: (err) => {
                this.router.navigate(['/auth/login']);
                console.error('Login failed!', err);
            }
        });
    } else {
        this.loginForm.markAllAsTouched();
    }
}
}
