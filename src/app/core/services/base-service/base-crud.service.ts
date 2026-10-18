import { HttpClient, HttpParams } from '@angular/common/http';
import { inject } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginationParams } from '../../models/api-query.model';

export abstract class BaseCrudService<
    TEntity = any,
    TCreateCommand = Partial<TEntity>,
    TUpdateCommand = Partial<TEntity>
> {
    protected readonly http = inject(HttpClient);

    protected constructor(protected readonly endpointUrl: string) {}

    getAll(queryParams?: PaginationParams): Observable<TEntity[]> {
        const params = this.buildHttpParams(queryParams);
        return this.http.get<TEntity[]>(this.endpointUrl, { params });
    }

    getById(id: string): Observable<TEntity> {
        return this.http.get<TEntity>(`${this.endpointUrl}/${id}`);
    }

    create(payload: TCreateCommand): Observable<TEntity> {
        return this.http.post<TEntity>(this.endpointUrl, payload);
    }

    update(id: string, payload: TUpdateCommand): Observable<TEntity> {
        return this.http.put<TEntity>(`${this.endpointUrl}/${id}`, payload);
    }

    delete(id: string): Observable<boolean | void> {
        return this.http.delete<boolean | void>(`${this.endpointUrl}/${id}`);
    }

    protected buildHttpParams(params?: PaginationParams): HttpParams {
        let httpParams = new HttpParams();
        if (!params) return httpParams;

        Object.entries(params).forEach(([key, value]) => {
            if (value !== undefined && value !== null && value !== '') {
                httpParams = httpParams.set(key, String(value));
            }
        });
        return httpParams;
    }
}