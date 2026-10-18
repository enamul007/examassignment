import { environment } from '../../environments/environment';
const baseUrl = environment.apiUrl;
export const API_ENDPOINTS = {
    // ==================== AUTHENTICATION ====================
    baseUrl:baseUrl,
    authorizer: {
        getAll:`${baseUrl}/authorizer/requests/checked`,
        create:`${baseUrl}/requests/checked`,
        getById:`${baseUrl}/requests/checked`,
        update:`${baseUrl}/requests/checked`
    },
    user:{
        create:`${baseUrl}/user/requests`,
        getAll:`${baseUrl}/authorizer/requests/checked`,
    },
} as const;
