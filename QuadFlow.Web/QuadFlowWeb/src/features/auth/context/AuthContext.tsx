import { createContext, useState } from "react"
import type { AuthProviderProps } from "../types/AuthProviderProps"
import type { AuthContextData } from "../types/authContextData";

export const AuthContext = createContext({} as AuthContextData);

export const AuthProvider = ({ children }: AuthProviderProps) => {

    const [isAuthenticated, setIsAuthenticated] = useState(false);

    function login(token: string) {
        localStorage.setItem("token", token);
        setIsAuthenticated(true);
    }

    function logout() {
        localStorage.removeItem("token");
        setIsAuthenticated(false);
    }

    return (
        <AuthContext.Provider
            value={{
                isAuthenticated,
                login,
                logout
            }}
        >
            {children}
        </AuthContext.Provider>
    );
};