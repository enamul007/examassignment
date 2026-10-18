export const environment = {
    production: false,
    apiUrl: 'http://localhost:5162/api', 
    auth: {
        accessTokenKey: 'accessToken',
        refreshTokenKey: 'refreshToken'
    },
    pagination: {
        pageSize: 10,
        first: 0,
        rowsPerPageOptions: [2, 3, 4, 5, 10, 20, 25, 50, 100]
    }
};