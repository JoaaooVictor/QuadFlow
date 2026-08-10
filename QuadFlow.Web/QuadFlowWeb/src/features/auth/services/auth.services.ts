import type { Result } from "../../../types/result.types";
import type { LoginRequestDto, LoginResponseDto } from "../types/auth.types";
import api from "../../../services/api/axios";

export async function Login(loginRequest: LoginRequestDto) {
    return await api.post<Result<LoginResponseDto>>("api/auth/login", loginRequest);
}