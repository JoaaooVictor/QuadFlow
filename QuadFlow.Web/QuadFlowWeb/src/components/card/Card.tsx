import type { CardProps } from "../card/CardProps";

export const Card = ({ title, value, icon }: CardProps) => {
    return (
        <article className="flex min-w-0 items-center gap-6 rounded-lg border border-gray-200 bg-white px-4 py-5">

            <div className="flex h-12 w-12 shrink-0 items-center justify-center rounded-lg bg-blue-50 text-black">
                {icon}
            </div>

            <div className="min-w-0">
                <p className="truncate text-sm font-medium text-gray-400">
                    {title}
                </p>

                <h2 className="truncate text-2xl font-bold text-gray-800">
                    {value}
                </h2>
            </div>

        </article>
    );
};