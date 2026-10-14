import { api } from "../../../services/api/axios";
import type { Result } from "../../../types/result.types";
import type { ResponseGetCompanyByUser } from "../types/ResponseGetCompanyByUser.types";

export async function DashboardService() {
    return await api.get<Result<ResponseGetCompanyByUser>>("api/company/get-company-by-user-authenticaded");
}