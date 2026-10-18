import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { SelectModule } from 'primeng/select';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { MultiSelectModule } from 'primeng/multiselect';
import { InputIconModule } from 'primeng/inputicon';
import { TagModule } from 'primeng/tag';
import { ToastModule } from 'primeng/toast';
import { CommonModule } from 'node_modules/@angular/common/types/_common_module-chunk';
import { IconFieldModule } from 'primeng/iconfield';

export const TABLE_IMPORTS = [
    ReactiveFormsModule, 
    TableModule, 
    MultiSelectModule, 
    SelectModule, 
    InputIconModule, 
    TagModule, 
    InputTextModule, 
    ToastModule, 
    CommonModule,
    FormsModule, 
    ButtonModule, 
    IconFieldModule
];
