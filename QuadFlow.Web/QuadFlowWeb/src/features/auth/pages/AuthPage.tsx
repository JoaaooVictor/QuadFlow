import { useState } from "react";
import type { LoginRequestDto } from "../types/auth.types";
import { Login } from "../services/auth.services";
import { useNavigate } from "react-router-dom";
import loginImage from "../../../assets/login-image.png";
import { toast } from "react-toastify";

export default function AuthPage() {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const navigate = useNavigate();

    async function handleLogin(event: React.SubmitEvent<HTMLFormElement>) {
        event.preventDefault();

        const request: LoginRequestDto = {
            email,
            password,
        };

        try {
            const response = await Login(request);

            if (!response.data.sucess) {
                toast.error(response.data.message);
                return;
            }

            if (response.status === 200) {
                localStorage.setItem("token", response.data.value.token);
                toast.success(response.data.message);
                navigate("/dashboard");
            }

        } catch (error) {
            toast.error("E-mail ou senha inválidos.");
        }
    }

    return (

        <main className="relative flex min-h-screen overflow-hidden bg-[#3E5C76]">
            <section className="relative hidden w-[40%] items-center justify-center bg-[#F0EBD8] lg:flex">
                <img
                    src={loginImage}
                    alt="Ilustração de login"
                    className="absolute right-[-50px] z-10 w-[400px] xl:right-[-80px] xl:w-[700px]"
                />
            </section>
            <section className="flex w-full items-center justify-center px-6 py-10 lg:w-[60%]">
                <form onSubmit={handleLogin} className="w-full max-w-md rounded-2xl bg-[#E0E0E0] p-8 shadow-2xl">
                    <div className="mb-8">
                        <h1 className="text-3xl font-bold text-[#26384A]">
                            Bem-vindo ao QuadFlow
                        </h1>

                        <p className="mt-2 text-sm text-gray-500">
                            Entre na sua conta para continuar.
                        </p>
                    </div>

                    <div className="mb-5">
                        <label
                            htmlFor="email"
                            className="mb-2 block text-sm font-semibold text-[#26384A]"
                        >
                            Email
                        </label>

                        <input
                            id="email"
                            type="email"
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                            placeholder="seu@email.com"
                            required
                            className="w-full rounded-lg border border-gray-300 bg-white px-4 py-3 text-gray-800 outline-none transition focus:border-[#3E5C76] focus:ring-2 focus:ring-[#3E5C76]/20"
                        />
                    </div>

                    <div className="mb-7">
                        <label
                            htmlFor="password"
                            className="mb-2 block text-sm font-semibold text-[#26384A]"
                        >
                            Senha
                        </label>

                        <input
                            id="password"
                            type="password"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            placeholder="Digite sua senha"
                            required
                            className="w-full rounded-lg border border-gray-300 bg-white px-4 py-3 text-gray-800 outline-none transition focus:border-[#3E5C76] focus:ring-2 focus:ring-[#3E5C76]/20"
                        />
                    </div>

                    <button
                        type="submit"
                        className="w-full rounded-lg bg-[#3E5C76] px-4 py-3 font-semibold text-white transition hover:bg-[#314A61] focus:outline-none focus:ring-2 focus:ring-[#3E5C76] focus:ring-offset-2 active:scale-[0.99]"
                    >
                        Entrar
                    </button>
                </form>
            </section>
        </main>
    );
}