import type { CardProps } from "../card/CardProps";

export const Card = ({title, color, content}: CardProps) =>{
    return(
        <div>
            <header style={{backgroundColor: color}}>{title}</header>
            <main>{content}</main>
            <footer>{}</footer>
        </div>
    )
}