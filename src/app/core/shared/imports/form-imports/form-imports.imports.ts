import { PasswordModule } from 'primeng/password';
import { DatePickerModule } from 'primeng/datepicker';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { SelectModule } from 'primeng/select';
import { InputNumberModule } from 'primeng/inputnumber';
import { CheckboxModule } from 'primeng/checkbox';
import { ToastModule } from 'primeng/toast';
import { CardModule } from 'primeng/card';


export const FORM_IMPORTS = [
    ReactiveFormsModule,
    CommonModule,
    FormsModule,
    InputNumberModule,
    CardModule,
    SelectModule,
    CheckboxModule,
    ToastModule,
    PasswordModule,
    ButtonModule,
    DatePickerModule
];