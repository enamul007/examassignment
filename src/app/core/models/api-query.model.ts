export interface PaginationParams {
    PageNumber?: number;
    PageSize?: number;
    OrganizationId?: string;
    [key: string]: string | number | boolean | undefined | null;
}