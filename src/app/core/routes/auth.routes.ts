import { LoginComponent } from '@/app/layout/components/login/login.component';
import { Routes } from '@angular/router'; 

export const authRoutes: Routes = [
    { path: 'login', component: LoginComponent },
    { path: '**', redirectTo: '/notfound' }
];