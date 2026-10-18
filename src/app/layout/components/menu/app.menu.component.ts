import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { AppMenuitem } from '../menuitem/app.menuitem.component';

@Component({
    selector: 'app-menu',
    standalone: true,
    imports: [CommonModule, AppMenuitem, RouterModule],
    templateUrl: './app.menu.component.html',
    styleUrl: './app.menu.component.scss'
})
export class AppMenu {
    model: MenuItem[] = [];

    ngOnInit() {
        this.model = [            
            {
                label: 'user',
                items: [{ label: 'user', icon: 'pi pi-fw pi-home', routerLink: ['/user'] }]
            },
            {
                label: 'checker',
                icon: 'pi pi-fw pi-calendar',
                items: [{ label: 'checker', icon: 'pi pi-fw pi-home', routerLink: ['/checker'] }]
            },
            {
                label: 'authorizer',
                icon: 'pi pi-fw pi-calendar',
                items: [{ label: 'authorizer', icon: 'pi pi-fw pi-home', routerLink: ['/authorizer'] }]
            },
        ];
    }
}
