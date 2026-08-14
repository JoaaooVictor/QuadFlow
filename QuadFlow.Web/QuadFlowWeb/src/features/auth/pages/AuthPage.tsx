import { useState } from "react";
import type { LoginRequestDto } from "../types/auth.types";
import { Login } from '../services/auth.services'
import { useNavigate } from "react-router-dom";

export default function AuthPage() {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const navigate = useNavigate();

    async function handleLogin(event: React.SubmitEvent<HTMLFormElement>) {
        event.preventDefault();

        const request: LoginRequestDto = {
            email,
            password
        };

        const response = await Login(request);

        if (response.status === 400) {
            console.log(response.data.message)
        }

        if (response.status === 200) {
            console.log(response.data.message)
            localStorage.setItem('token', response.data.value.token);
            navigate('/dashboard');
        }
    };

    return (
        <main className="flex min-h-screen">
            <section className="w-[35%] bg-[#F0EBD8]">
            </section>
            <section className="flex w-[65%] items-center justify-center bg-[#3E5C76]">
                <form onSubmit={handleLogin} className="h-[30rem] min-w-[35%] max-w-md rounded-md bg-[#E0E0E0] p-8">
                    <h1 className="mb-[10px]">
                        Bem vindo ao QuadFlow
                    </h1>
                    <div className="flex flex-col gap-[10px]">
                        <label>Email</label>
                        <input
                            type="email"
                            value={email}
                            onChange={e => setEmail(e.target.value)}
                            className="rounded-[10px] p-[10px]"
                        />
                    </div>

                    <div className="flex flex-col gap-[10px]">
                        <label>Senha</label>
                        <input
                            type="password"
                            value={password}
                            onChange={e => setPassword(e.target.value)}
                            className="rounded-[10px] p-[10px]"
                        />
                    </div>

                    <button type="submit">
                        Entrar
                    </button>
                </form>
            </section>
        </main>
    );
};