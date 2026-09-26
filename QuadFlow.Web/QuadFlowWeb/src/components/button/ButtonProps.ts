export interface ButtonProps{
    title: string,
    titleColor: string,
    bgColor?: string,
    icon?: React.ReactNode,
    onClick: () => void
}