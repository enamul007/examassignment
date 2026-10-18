// import { Injectable } from '@angular/core';
// import { BaseApiService } from './base-service/base-api.service';
// import { Observable } from 'rxjs';
// @Injectable({
//   providedIn: 'root'
// })
// export class AuthorizerService extends BaseApiService<any> {   
//   protected readonly endpoint = 'requests';        
//   getAllAuthorizer(): Observable<any[]> {
//     return this.getAll();
//   } 
//   getAuthorizerById(id: string): Observable<any> {
//     return this.getById(id);    
//   } 
//   createAuthorizer(payload: any): Observable<any> {
//     return this.create(payload);
//   } 
//   updateAuthorizer(id: string, payload: any): Observable<any> {
//     return this.update(id, payload);
//   } 
//   deleteAuthorizer(id: string): Observable<void> {
//     return this.delete(id);
//   }
// }

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
export class AuthorizerService extends BaseCrudService {
    private readonly httpClient = inject(HttpClient);
    constructor() {
        super(API_ENDPOINTS.baseUrl);
    }
    override getAll(query: any = {}): Observable<any> {
        return this.httpClient.get<PagedResult<any>>(API_ENDPOINTS.authorizer.getAll, { params: buildParams(query) });
    }
    override getById(id: string): Observable<any> {
        return this.httpClient.get<any>(`${API_ENDPOINTS.authorizer}/${id}`);
    }

    override create(request: any): Observable<any> {
        return this.httpClient.post<any>(API_ENDPOINTS.authorizer.create, request);
    }

    override update(id: string, request: any): Observable<void> {
        return this.httpClient.put<void>(`${API_ENDPOINTS.authorizer}/${id}`, request);
    }

    override delete(id: string): Observable<boolean> {
        return this.httpClient.delete<boolean>(`${API_ENDPOINTS.authorizer}/${id}`);
    }
}