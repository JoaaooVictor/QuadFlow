import type { CardProps } from "../card/CardProps";

export const Card = ({ title, value, icon }: CardProps) => {
    return (
        <article className="flex h-30 items-center gap-4 rounded-lg border border-gray-200 bg-white px-6 py-5">
            <div className="flex h-12 w-12 items-center justify-center rounded-lg bg-blue-50 text-black">
                {icon}
            </div>
            <div>
                <p className="text-sm font-medium text-gray-400">
                    {title}
                </p>
                <h2 className="text-2xl font-bold text-gray-800">
                    {value}
                </h2>
            </div>
        </article>
    );
};