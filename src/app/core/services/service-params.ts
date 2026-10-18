import { HttpParams } from "@angular/common/http";
import { QueryParams } from "../models/query-params.model";
export function buildParams(query: QueryParams): HttpParams {
    let params = new HttpParams();
    if (query.pageNumber !== undefined) params = params.set('pageNumber', query.pageNumber);
    if (query.pageSize !== undefined) params = params.set('pageSize', query.pageSize);
    if (query.search) params = params.set('search', query.search);
    if (query.sortField) params = params.set('sortField', query.sortField);
    if (query.sortOrder) params = params.set('sortOrder', query.sortOrder);
    if (query.organizationId) params = params.set('organizationId', query.organizationId);
    if (query.firstName) params = params.set('firstName', query.firstName);
    if (query.lastName) params = params.set('lastName', query.lastName);
    if (query.phone) params = params.set('phone', query.phone);
    if (query.isActive !== undefined) params = params.set('isActive', query.isActive);
    return params;
}