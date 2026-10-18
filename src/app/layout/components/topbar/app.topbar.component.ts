import { Component, OnInit, inject } from '@angular/core'; // Added OnInit
import { MenuItem } from 'primeng/api';
import { RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { StyleClassModule } from 'primeng/styleclass';
import { LayoutService } from '@/app/core/services/layout.service';
import { AppConfigurator } from '../configurator/app.configurator.component';
import { MenuModule } from 'primeng/menu';
import { AuthService } from '@/app/core/services/auth/auth.service';
import { StorageService } from '@/app/core/services/storage.service';

@Component({
    selector: 'app-topbar',
    standalone: true,
    imports: [RouterModule, CommonModule, StyleClassModule, AppConfigurator, MenuModule],
    templateUrl: './app.topbar.component.html',
    styleUrl: './app.topbar.component.scss'
})
export class AppTopbar implements OnInit {
    // Implemented OnInit
    items!: MenuItem[];
    private storageService = inject(StorageService);
    layoutService = inject(LayoutService);
    router = inject(Router);
    authService = inject(AuthService);

    nestedMenuItems: MenuItem[] = []; // Initialized as empty array

    ngOnInit() {
        // Moved initialization here
        this.nestedMenuItems = [
            {
                label: 'Account',
                items: [
                    {
                        label: 'Logout',
                        icon: 'pi pi-fw pi-sign-out',
                        command: () => this.logout()
                    }
                ]
            }
        ];
    }

    toggleDarkMode() {
        this.layoutService.layoutConfig.update((state) => ({
            ...state,
            darkTheme: !state.darkTheme
        }));
    }

    logout() {
        this.authService.logout(); //role
        this.storageService.clearAll();
        this.router.navigate(['/auth/login']);
    }
}
