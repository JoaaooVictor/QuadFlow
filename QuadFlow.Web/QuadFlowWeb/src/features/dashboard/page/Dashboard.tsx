import { Card } from "../../../components/card/Card"

export const DashboardPage = () =>{
    return (
        <div className="flex min-h-screen">
            <aside className="w-50 bg-blue-50">
                
            </aside>
            <div className="flex-1">
                <header className="h-16 bg-blue-100">
                    <h1>Incluir icone de configuração</h1>
                </header>
                <main>
                    <section>
                        <Card title="Reserva 2" color="#3E5C76" content="Teste 2"/>
                    </section>
                    <section>
                        Proximas reservas
                    </section>
                </main>
            </div>
        </div>
    )
}