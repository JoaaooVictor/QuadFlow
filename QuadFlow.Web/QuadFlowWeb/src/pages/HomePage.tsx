import Navbar from "../components/navbar/Navbar"

export const HomePage = () => {
    return (
        <div>
            <header>
                <Navbar />
            </header>
            <main>
                <section id="hero">
                    <h1 className="text-3xl font-bold">Organize sua quadra de forma simples e eficiente.</h1>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>
                </section>
                <section id="sobre">
                    <h1 className="text-3xl font-bold">Sobre o QuadFlow</h1>
                    <p className="text-sm">Somos um sistema desenvolvido para ajudar você a gerenciar sua quadra de forma prática, organizada e segura. Com uma interface intuitiva e moderna, o QuadFlow foi criado para facilitar o seu dia a dia, seja no controle de comandas, produtos, agenda ou no gerenciamento de alunos.</p>
                    <h2 className="text-lg font-bold">Beneficios</h2>
                    <h3 className="text-sm font-bold">Mais controle</h3>
                    <p className="text-sm">Tudo o que você precisa em um só lugar.</p>
                    <h3 className="text-sm font-bold">Mais Agilidade</h3>
                    <p className="text-sm">Otimize seu tempo e foque no que importa.</p>
                    <h3 className="text-sm font-bold">Mais Resultados</h3>
                    <p className="text-sm">Um sistema feito para o seu crescimento.</p>
                </section>
                <section id="recursos">
                    <h1 className="text-3xl font-bold">Recursos que fazem a diferença.</h1>
                    <p className="text-sm">Tudo o que você precisa para gerenciar sua quadra de forma completa e eficiente.</p>

                    <h2 className="text-lg font-bold">Comandas</h2>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>

                    <h2 className="text-lg font-bold">Produtos</h2>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>

                    <h2 className="text-lg font-bold">Agenda</h2>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>

                    <h2 className="text-lg font-bold">Alunos</h2>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>

                    <h2 className="text-lg font-bold">Relatórios</h2>
                    <p className="text-sm">O QuadFlow é o sistema ideal para gerenciar comandas, produtos, agenda e muito mais. Tudo em um só lugar, com praticidade, agilidade e segurança.</p>

                </section>
            </main>
        </div>
    )
}