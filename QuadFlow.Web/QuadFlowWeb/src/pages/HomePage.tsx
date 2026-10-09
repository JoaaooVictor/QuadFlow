import Navbar from "../components/navbar/Navbar";
import homeImage from "../assets/home-image-alt.png";

export const HomePage = () => {
    return (
        <div className="min-h-screen bg-[#F8F9FA] text-[#1D3557]">
            <header>
                <Navbar />
            </header>

            <main>
                <section id="hero" className="flex min-h-[600px] bg-gray-100 items-center justify-center">
                    <div className="mx-auto grid max-w-6xl items-center gap-12 md:grid-cols-2">
                        <div className="flex flex-col gap-6">
                            <span className="w-fit rounded-full bg-[#DCE8F2] px-4 py-2 text-sm font-semibold text-[#3E5C76]">
                                SISTEMA COMPLETO PARA SUA QUADRA
                            </span>

                            <h1 className="text-4xl font-bold leading-tight md:text-5xl">
                                Organize sua quadra de forma simples e eficiente.
                            </h1>

                            <p className="max-w-xl text-base leading-7 text-gray-600 md:text-lg">
                                O QuadFlow é o sistema ideal para gerenciar comandas,
                                produtos, agenda e muito mais. Tudo em um só lugar,
                                com praticidade, agilidade e segurança.
                            </p>

                            <div className="flex flex-wrap gap-4">
                                <a href="auth" className="rounded-lg bg-[#3E5C76] px-6 py-3 font-semibold text-white transition hover:bg-[#304A61]">
                                    Começar agora
                                </a>

                                <a href="#recursos" className="rounded-lg border border-[#3E5C76] px-6 py-3 font-semibold text-[#3E5C76] transition hover:bg-[#3E5C76] hover:text-white">
                                    Conheça os recursos
                                </a>
                            </div>
                        </div>

                        <div className="flex justify-center">
                            <img src={homeImage} alt="Dashboard do QuadFlow" className="w-full max-w-xl object-contain"/>
                        </div>
                    </div>
                </section>

                <section id="sobre" className="bg-white px-6 py-20">
                    <div className="mx-auto max-w-6xl">
                        <div className="max-w-3xl">
                            <span className="text-sm font-semibold text-[#3E5C76]">
                                SOBRE NÓS
                            </span>

                            <h2 className="mt-3 text-3xl font-bold md:text-4xl">
                                Sobre o QuadFlow
                            </h2>

                            <p className="mt-6 leading-7 text-gray-600">
                                Somos um sistema desenvolvido para ajudar você a
                                gerenciar sua quadra de forma prática, organizada
                                e segura. Com uma interface intuitiva e moderna,
                                o QuadFlow foi criado para facilitar o seu dia a
                                dia, seja no controle de comandas, produtos,
                                agenda ou no gerenciamento de alunos.
                            </p>
                        </div>

                        <div className="mt-12 grid gap-6 md:grid-cols-3">
                            <article className="rounded-xl border border-gray-200 bg-[#F8F9FA] p-6">
                                <h3 className="text-xl font-bold">
                                    Mais controle
                                </h3>

                                <p className="mt-3 text-gray-600">
                                    Tudo o que você precisa em um só lugar.
                                </p>
                            </article>

                            <article className="rounded-xl border border-gray-200 bg-[#F8F9FA] p-6">
                                <h3 className="text-xl font-bold">
                                    Mais agilidade
                                </h3>

                                <p className="mt-3 text-gray-600">
                                    Otimize seu tempo e foque no que importa.
                                </p>
                            </article>

                            <article className="rounded-xl border border-gray-200 bg-[#F8F9FA] p-6">
                                <h3 className="text-xl font-bold">
                                    Mais resultados
                                </h3>

                                <p className="mt-3 text-gray-600">
                                    Um sistema feito para o seu crescimento.
                                </p>
                            </article>
                        </div>
                    </div>
                </section>

                <section id="recursos" className="px-6 py-20 bg-gray-100">
                    <div className="mx-auto max-w-6xl">
                        <div className="max-w-3xl">
                            <span className="text-sm font-semibold text-[#3E5C76]">
                                RECURSOS
                            </span>

                            <h2 className="mt-3 text-3xl font-bold md:text-4xl">
                                Recursos que fazem a diferença
                            </h2>

                            <p className="mt-6 leading-7 text-gray-600">
                                Tudo o que você precisa para gerenciar sua
                                quadra de forma completa e eficiente.
                            </p>
                        </div>

                        {/* Cards */}
                        <div className="mt-12 grid gap-6 sm:grid-cols-2 lg:grid-cols-3">
                            
                            <article className="rounded-xl bg-white p-6 shadow-sm transition hover:-translate-y-1 hover:shadow-md">
                                <h3 className="text-xl font-bold">
                                    Comandas
                                </h3>

                                <p className="mt-3 leading-6 text-gray-600">
                                    Crie e gerencie comandas com rapidez e
                                    praticidade.
                                </p>
                            </article>

                            <article className="rounded-xl bg-white p-6 shadow-sm transition hover:-translate-y-1 hover:shadow-md">
                                <h3 className="text-xl font-bold">
                                    Produtos
                                </h3>

                                <p className="mt-3 leading-6 text-gray-600">
                                    Cadastre seus produtos, controle o estoque
                                    e defina preços.
                                </p>
                            </article>

                            <article className="rounded-xl bg-white p-6 shadow-sm transition hover:-translate-y-1 hover:shadow-md">
                                <h3 className="text-xl font-bold">
                                    Agenda
                                </h3>

                                <p className="mt-3 leading-6 text-gray-600">
                                    Organize seus horários e evite conflitos
                                    de reservas.
                                </p>
                            </article>

                            <article className="rounded-xl bg-white p-6 shadow-sm transition hover:-translate-y-1 hover:shadow-md">
                                <h3 className="text-xl font-bold">
                                    Alunos
                                </h3>

                                <p className="mt-3 leading-6 text-gray-600">
                                    Gerencie seus alunos e mantenha tudo
                                    organizado.
                                </p>
                            </article>

                            <article className="rounded-xl bg-white p-6 shadow-sm transition hover:-translate-y-1 hover:shadow-md">
                                <h3 className="text-xl font-bold">
                                    Relatórios
                                </h3>

                                <p className="mt-3 leading-6 text-gray-600">
                                    Tenha acesso a informações importantes
                                    para tomar melhores decisões.
                                </p>
                            </article>

                        </div>
                    </div>
                </section>
                <section className="px-6 py-20 bg-white">
                    <div className="mx-auto flex max-w-6xl flex-col items-center justify-between gap-6 rounded-2xl bg-[#3E5C76] px-8 py-12 text-center text-white md:flex-row md:text-left">
                        <div>
                            <h2 className="text-3xl font-bold">
                                Pronto para levar sua quadra para o próximo nível?
                            </h2>

                            <p className="mt-3 max-w-2xl text-gray-200">
                                Comece agora e descubra como o QuadFlow pode
                                facilitar sua gestão e aumentar seus resultados.
                            </p>
                        </div>

                        <a
                            href="/auth"
                            className="shrink-0 rounded-lg bg-white px-6 py-3 font-semibold text-[#3E5C76] transition hover:bg-gray-100"
                        >
                            Começar agora
                        </a>
                    </div>
                </section>
            </main>
        </div>
    );
};