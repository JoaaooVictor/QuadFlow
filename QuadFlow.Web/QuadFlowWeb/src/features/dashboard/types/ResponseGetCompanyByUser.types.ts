export interface ResponseGetCompanyByUser{
    companyId: number;
    name: string;
    cnpj: {
        value: string;
    };
    createdAt: string;
}