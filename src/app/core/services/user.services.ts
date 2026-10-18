import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseCrudService } from './base-service/base-crud.service';
import { API_ENDPOINTS } from '../constants/api-endpoints/api-endpoints';
import { PagedResult } from '../models/paged-result';
import { buildParams } from './service-params';
@Injectable({
    providedIn: 'root'
})
export class UserService extends BaseCrudService {
    private readonly httpClient = inject(HttpClient);
    constructor() {
        super(API_ENDPOINTS.baseUrl);
    }
    override getAll(query: any = {}): Observable<any> {
        return this.httpClient.get<PagedResult<any>>(API_ENDPOINTS.user.getAll, { params: buildParams(query) });
    }
    override getById(id: string): Observable<any> {
        return this.httpClient.get<any>(`${API_ENDPOINTS.authorizer}/${id}`);
    }

    override create(request: any): Observable<any> {
        return this.httpClient.post<any>(API_ENDPOINTS.user.create, request);
    }

    override update(id: string, request: any): Observable<void> {
        return this.httpClient.put<void>(`${API_ENDPOINTS.authorizer}/${id}`, request);
    }

    override delete(id: string): Observable<boolean> {
        return this.httpClient.delete<boolean>(`${API_ENDPOINTS.authorizer}/${id}`);
    }
    approve(id: string | number, request: any): Observable<any> {
        const url = API_ENDPOINTS.baseUrl+`/authorizer/requests/${id}/authorize`;
        return this.httpClient.put<any>(url, request);
    }
}
