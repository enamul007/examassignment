import {Component, computed, inject, input} from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { StyleClassModule } from 'primeng/styleclass'; 
import { LayoutService } from '@/app/core/services/layout.service';
import {CommonModule} from "@angular/common";
import { AppConfigurator } from '../configurator/app.configurator.component';

@Component({
    selector: 'app-floating-configurator',
    imports: [CommonModule, ButtonModule, StyleClassModule, AppConfigurator],
    templateUrl: './app.floatingconfigurator.component.html',
    styleUrl: './app.floatingconfigurator.component.scss'
})
export class AppFloatingConfigurator {
    LayoutService = inject(LayoutService); 

    float = input<boolean>(true);

    isDarkTheme = computed(() => this.LayoutService.layoutConfig().darkTheme);

    toggleDarkMode() {
        this.LayoutService.layoutConfig.update((state) => ({ ...state, darkTheme: !state.darkTheme }));
    }
}