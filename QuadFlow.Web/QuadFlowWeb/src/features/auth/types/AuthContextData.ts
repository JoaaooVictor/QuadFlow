import type { LoginRequestDto } from "./auth.types";

export interface AuthContextData {
    isAuthenticated: boolean;
    login: (token: string) => void;
    logout: () => void;
}
