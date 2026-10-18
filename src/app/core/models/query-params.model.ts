export interface QueryParams {
    pageNumber?: number;
    pageSize?: number;
    search?: string;
    status: string|null;
    sortField?: string;
    sortOrder?: string;
    organizationId?: string;
    firstName?: string;
    lastName?: string;
    phone?: string;
    isActive?: boolean;
}