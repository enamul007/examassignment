import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { BaseApiService } from '../base-service/base-api.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService extends BaseApiService<any> {   
  protected readonly endpoint = 'auth';   
  private readonly TOKEN_KEY = 'accessToken';
  login(credentials: any): Observable<any> {
    return this.http.post<any>(`${this.url}/login`, credentials).pipe(
      tap(response => {
        if (response?.accessToken) {
          localStorage.setItem(this.TOKEN_KEY, response.accessToken);
        }
        if (response?.refreshToken) {
          localStorage.setItem('refreshToken', response.refreshToken);
        }
        if (response?.role) {
          localStorage.setItem('role', response.role);
        }
      }),
      catchError(this.handleError.bind(this)) 
    );
  }
  getToken(): string | null {
    return localStorage.getItem(this.TOKEN_KEY);
  }
  logout(): void {
    localStorage.removeItem(this.TOKEN_KEY);
  }
}