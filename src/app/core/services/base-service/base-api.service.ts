import { HttpClient, HttpErrorResponse, HttpParams, HttpHeaders, HttpContext } from '@angular/common/http';
import { inject } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { environment } from '../../environments/environment';
export interface HttpOptions {
  headers?: HttpHeaders | { [header: string]: string | string[] };
  context?: HttpContext;
  observe?: 'body';
  params?: HttpParams | { [param: string]: string | number | boolean | ReadonlyArray<string | number | boolean> };
  reportProgress?: boolean;
  withCredentials?: boolean;
}
export abstract class BaseApiService<T> {
  protected readonly http = inject(HttpClient);
  protected abstract readonly endpoint: string;
  protected readonly baseUrl: string = environment.apiUrl;
  protected get url(): string {
    return `${this.baseUrl}/${this.endpoint}`;
  }

  /**
   * Retrieves all records.
   * @param options Optional HTTP parameters, headers, or context.
   */
  getAll(options?: HttpOptions): Observable<T[]> {
    return this.http.get<T[]>(this.url, options).pipe(
      retry(1), 
      catchError(this.handleError.bind(this))
    );
  }

  /**
   * Retrieves a single record by its ID.
   */
  getById(id: string | number, options?: HttpOptions): Observable<T> {
    return this.http.get<T>(`${this.url}/${id}`, options).pipe(
      retry(1),
      catchError(this.handleError.bind(this))
    );
  }

  /**
   * Creates a new record.
   */
  create(item: Partial<T>, options?: HttpOptions): Observable<T> {
    return this.http.post<T>(this.url, item, options).pipe(
      catchError(this.handleError.bind(this))
    );
  }
  update(id: string | number, item: Partial<T>, options?: HttpOptions): Observable<T> {
    return this.http.put<T>(`${this.url}/${id}`, item, options).pipe(
      catchError(this.handleError.bind(this))
    );
  }

  patch(id: string | number, changes: Partial<T>, options?: HttpOptions): Observable<T> {
    return this.http.patch<T>(`${this.url}/${id}`, changes, options).pipe(
      catchError(this.handleError.bind(this))
    );
  }

  delete(id: string | number, options?: HttpOptions): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`, options).pipe(
      catchError(this.handleError.bind(this))
    );
  }
  protected handleError(error: HttpErrorResponse): Observable<never> {
    let errorMessage = 'An unknown error occurred';
    
    if (error.error instanceof ErrorEvent) {
      errorMessage = `Client Error: ${error.error.message}`;
    } else {
      errorMessage = error.error?.message || `Server Error ${error.status}: ${error.message}`;
    }
    
    if (!environment.production) {
      console.error('[API Error]', errorMessage, error);
    }
    return throwError(() => new Error(errorMessage));
  }
}