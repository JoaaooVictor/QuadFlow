import type { CardProps } from "../card/CardProps";

export const Card = ({ title, color, content }: CardProps) => {
    return (
        <article className="w-64 h-32 rounded-xl border border-gray-200 shadow-sm overflow-hidden flex flex-col">
            <header
                className="px-4 py-2 text-white font-semibold"
                style={{ backgroundColor: color }}
            >
                {title}
            </header>

            <main className="flex flex-1 items-center justify-center text-2xl font-bold">
                {content}
            </main>

            <footer>
            </footer>
        </article>
    );
};
