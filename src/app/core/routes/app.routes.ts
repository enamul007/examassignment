import { Routes } from '@angular/router';
import { LoginComponent } from '@/app/layout/components/login/login.component';
import { authGuard } from '../guards/auth.guard';
import { Authorizers } from '@/app/layout/components/authorizer/authorizer.component';
import { Checkers } from '@/app/layout/components/checker/checker.component';
import { Documents } from '@/app/layout/components/documents/documents.component';
import { Users } from '@/app/layout/components/User/user.component';

export const appRoutes: Routes = [
    {
        path: '',
        component: LoginComponent
    },
    {
        path: 'documents',
        component: Documents,
        canActivate: [authGuard]
    },
    {
        path: 'user/:title',
        component: Users,
        canActivate: [authGuard]
    },
    {
        path: 'authorizer/:title',
        component: Authorizers,
        canActivate: [authGuard]
    },
    {
        path: 'checker/:title',
        component: Checkers,
        canActivate: [authGuard]
    },
    { path: 'auth', loadChildren: () => import('../routes/auth.routes').then((m) => m.authRoutes) },
    { path: '**', redirectTo: '' }
];
