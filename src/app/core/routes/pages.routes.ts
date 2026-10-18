import { Routes } from '@angular/router';
import { authGuard } from '../guards/auth.guard';

export const pagesRoutes: Routes = [     
    { path: '**', redirectTo: '/notfound' }
];