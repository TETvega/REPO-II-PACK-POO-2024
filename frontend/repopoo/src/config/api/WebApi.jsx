import axios from "axios";
const API_URL = 'https://localhost:7092/api';
const webApi = axios.create({
    baseURL: API_URL,
    headers: {
        "Content-Type": "application/json"
    }
}); 

// TODO: Add interceptors
export {
    webApi,
    API_URL
}