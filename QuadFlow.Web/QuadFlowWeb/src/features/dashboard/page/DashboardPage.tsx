import { Card } from "../../../components/card/Card";
import { Banknote, ClipboardCheck, Hamburger, UserGroup } from "lucide-react";

export const DashboardPage = () => {
    return (
        <div className="min-h-full">
            <section className="px-8 pt-8">
                <h1 className="text-2xl font-bold text-gray-800">
                    Olá João Victor!
                </h1>

                <p className="text-sm text-gray-500">
                    Aqui está um resumo do seu negócio hoje.
                </p>
            </section>
            <section className="grid grid-cols-1 gap-4 px-8 py-6 md:grid-cols-2 xl:grid-cols-4">
                <Card
                    title="Comandas Hoje"
                    value="30"
                    icon={<ClipboardCheck size={24} />}
                    format=""
                />
                <Card
                    title="Produtos Vendidos"
                    value="429"
                    icon={<Hamburger size={24} />}
                    format=""
                />
                <Card
                    title="Alunos Ativos"
                    value="890"
                    icon={<UserGroup size={24} />}
                    format=""
                />
                <Card
                    title="Faturamento"
                    value="R$ 100.000,00"
                    icon={<Banknote size={24} />}
                    format=""
                />
            </section>
        </div>
    );
};