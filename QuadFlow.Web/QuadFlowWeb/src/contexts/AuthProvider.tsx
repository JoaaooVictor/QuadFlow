import { useState } from "react";
import { AuthContext } from "./AuthContext";
import { useContext } from "react";

interface AuthProviderProps {
    children: React.ReactNode;
}

export const AuthProvider = ({ children }: AuthProviderProps) => {

    const [token, setToken] = useState<string | null>(
        localStorage.getItem("token")
    );

    function login(token: string) {
        localStorage.setItem("token", token);
        setToken(token);
    }

    function logout() {
        localStorage.removeItem("token");
        setToken(null);
    }

    return (
        <AuthContext.Provider
            value={{
                token,
                isAuthenticated: !!token,
                login,
                logout
            }}
        >
            {children}
        </AuthContext.Provider>
    );
};

export const useAuth = () => {

    const context = useContext(AuthContext);

    if (!context) {
        throw new Error(
            "useAuth deve ser utilizado dentro de um AuthProvider"
        );
    }

    return context;
};