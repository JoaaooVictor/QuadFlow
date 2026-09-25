import type { StatsCardsProps } from "./StatCardsProps"

export const StatCard = ({ value, color, title }: StatsCardsProps) => {
    return (
        <article className="flex w-40 h-24 flex-col items-center justify-center rounded-mdshadow-sm">
            <h2 className="text-sm font-medium text-gray-600">
                {title}
            </h2>

            <main className="text-2xl font-bold" style={{ color: color }}>
                {value}
            </main>
        </article>
    );
};

