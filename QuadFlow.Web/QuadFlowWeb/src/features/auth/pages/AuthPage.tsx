import { useState } from "react";
import type { LoginRequestDto } from "../types/auth.types";
import { Login } from '../services/auth.services'

export default function AuthPage() {
    async function handleLogin(event: React.SubmitEvent<HTMLFormElement>){
        event.preventDefault();

        const request: LoginRequestDto = {
            email,
            password
        };

        const response = await Login(request);
        
        if(response.status === 400){
            console.log(response.data.message)
        }

        if(response.status === 200){
            console.log(response.data.message)
            localStorage.setItem('token', response.data.value.token);
        }
    };

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    return (
        <main>
            <form onSubmit={handleLogin}>
                <h1>Bem vindo ao QuadFlow</h1>
                <div>
                    <label>Email</label>
                    <input
                        type="email"
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                    />
                </div>
                <div>
                    <label>Senha</label>
                    <input
                        type="password"
                        value={password}
                        onChange={e => setPassword(e.target.value)}
                    />
                </div>
                <button type="submit">Entrar</button>
            </form>
        </main>
    );
};