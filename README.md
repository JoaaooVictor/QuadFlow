# QuadFlow

> Sistema web para gerenciamento de quadras esportivas, com foco em centralizar a operação do negócio em uma única plataforma.

O **QuadFlow** é um projeto de estudo e desenvolvimento de software que busca facilitar a administração de quadras esportivas. A proposta é reunir funcionalidades como gestão de empresas, produtos, comandas e agenda em uma aplicação com API própria e interface web.

O projeto também serve como laboratório prático para aprofundar conhecimentos em **C#, .NET, React, TypeScript, arquitetura modular, Domain-Driven Design (DDD), autenticação e CI/CD**.

## Objetivos

- Centralizar informações e rotinas operacionais de uma quadra esportiva.
- Separar responsabilidades de negócio em módulos com limites claros.
- Construir uma API REST com autenticação e persistência de dados.
- Desenvolver uma interface web responsiva.
- Aplicar gradualmente princípios de arquitetura e automação de qualidade.

## Funcionalidades

O sistema está em desenvolvimento. A estrutura e as funcionalidades evoluem conforme o projeto avança.

- **Autenticação:** fluxo de login com JWT.
- **Empresas:** consulta e gerenciamento de informações da empresa associada ao usuário autenticado.
- **Dashboard:** interface inicial para apresentar informações relevantes da operação.
- **Comandas:** área da aplicação destinada ao gerenciamento de comandas.
- **Produtos:** área para organização e gerenciamento de produtos.
- **Agenda:** funcionalidade planejada para apoiar a organização de horários.
- **Usuários:** estrutura modular para operações relacionadas a usuários.

> Nem todas as funcionalidades listadas estão necessariamente concluídas. Consulte o código e o histórico do repositório para verificar o estado atual de cada módulo.

## Tecnologias

### Backend
- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Bearer Authentication
- Swagger / OpenAPI

### Frontend
- React
- TypeScript
- Vite
- Tailwind CSS
- React Router
- Axios
- React Toastify
- Lucide React

### Qualidade e DevOps
- Git e GitHub
- GitHub Actions para integração contínua (CI)
- xUnit/testes automatizados, conforme implementados na solução

## Arquitetura

O QuadFlow segue a direção de um **monólito modular**, com separação de responsabilidades inspirada em DDD. A intenção é manter os módulos no mesmo sistema implantável, evitando a complexidade operacional de microserviços nesta etapa.

Visão simplificada da solução:

```text
QuadFlow/
├── .github/
│   └── workflows/
│       └── ci.yml
├── Modules/
│   ├── Auth/
│   ├── User/
│   └── Company/
├── QuadFlow.Api/
├── QuadFlow.SharedKernel/
├── QuadFlow.Web/
└── QuadFlow.slnx
```

> A árvore acima é uma visão resumida. Os nomes e a organização exata dos projetos internos devem ser conferidos na versão atual do repositório.

### Responsabilidades gerais

- **QuadFlow.Api:** ponto de entrada HTTP, configuração da aplicação, controllers e composição das dependências.
- **Modules:** agrupam funcionalidades e regras específicas de cada contexto de negócio.
- **QuadFlow.SharedKernel:** contém abstrações e conceitos compartilhados entre módulos, como o contrato `ICurrentUser` quando aplicável.
- **QuadFlow.Web:** interface web em React e TypeScript.
- **GitHub Actions:** automatiza etapas de restauração, build e testes da solução.

### Princípios de arquitetura

O desenvolvimento busca aplicar progressivamente:

- Separação de responsabilidades.
- Encapsulamento das regras de negócio nos módulos.
- Inversão de dependência e uso de abstrações.
- Value Objects para representar conceitos do domínio, quando apropriado.
- Contratos explícitos entre módulos.
- Autenticação e autorização no backend.
- Testes automatizados e integração contínua.

O `SharedKernel` não deve funcionar como um local genérico para toda a lógica da aplicação. A intenção é manter nele apenas o que realmente é compartilhado.

## Pré-requisitos

Para executar o projeto localmente, tenha instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) em versão compatível com o Vite utilizado
- [SQL Server](https://www.microsoft.com/sql-server) ou uma instância compatível
- Git
- Ferramenta de sua preferência para inspecionar a API, como Swagger ou Insomnia

Para gerenciar migrations do Entity Framework Core, pode ser necessário instalar a ferramenta `dotnet-ef` em uma versão compatível com os pacotes EF Core da solução.

## Como executar localmente

### 1. Clonar o repositório

```bash
git clone https://github.com/JoaaooVictor/QuadFlow.git
cd QuadFlow
```

### 2. Configurar o banco de dados

Configure a connection string do SQL Server para os ambientes locais. Não versionar senhas, tokens ou outras credenciais.

Use User Secrets, variáveis de ambiente ou outro mecanismo seguro de configuração para valores sensíveis. Confira os nomes de configuração esperados no código da API e nos módulos de infraestrutura.

### 3. Aplicar as migrations

A solução pode possuir um `DbContext` por módulo. Verifique quais contextos existem e aplique as migrations de cada um conforme os projetos e os ambientes configurados.

Exemplo de formato para um contexto de usuário (ajuste os caminhos aos nomes reais dos projetos):

```bash
dotnet ef database update \
  --project Modules/User/User.Infrastructure \
  --startup-project QuadFlow.Api \
  --context UserDbContext
```

No PowerShell, o comando pode ser executado em uma única linha:

```powershell
dotnet ef database update --project Modules/User/User.Infrastructure --startup-project QuadFlow.Api --context UserDbContext
```

Repita o procedimento para os demais contextos existentes, como o de empresas, se aplicável. Confirme os caminhos e nomes diretamente na solução antes de executar.

### 4. Restaurar, compilar e testar a API

Na raiz da solução:

```bash
dotnet restore
dotnet build
dotnet test
```

Se algum comando depender de um nome de solução ou caminho específico, utilize o arquivo de solução presente no repositório.

### 5. Executar a API

```bash
dotnet run --project QuadFlow.Api
```

Consulte a saída do terminal para identificar a URL local e a rota do Swagger. As URLs e portas podem variar de acordo com o perfil de execução.

### 6. Executar o frontend

Abra outro terminal:

```bash
cd QuadFlow.Web
npm install
npm run dev
```

O Vite exibirá a URL local do frontend no terminal.

Configure a URL base da API na instância Axios do frontend para corresponder ao endereço local da API. Se usar variáveis de ambiente do Vite, lembre-se de que as variáveis expostas ao navegador devem usar o prefixo `VITE_` e não devem conter segredos.

## Autenticação

O backend utiliza JWT para autenticar requisições protegidas. O frontend deve enviar o token no cabeçalho:

```http
Authorization: Bearer <token>
```

A API deve validar o token e obter a identidade do usuário a partir das claims autenticadas. Não confie em identificadores enviados pelo cliente para conceder acesso a dados de outro usuário ou empresa.

Os detalhes de emissão do token, claims e endpoints devem ser consultados na implementação atual do módulo de autenticação.

## Integração contínua

O repositório possui um workflow de GitHub Actions destinado a automatizar etapas de integração contínua, como:

1. Checkout do código.
2. Configuração do SDK do .NET.
3. Restauração das dependências.
4. Build da solução.
5. Execução dos testes automatizados.

Consulte `.github/workflows/ci.yml` para verificar os gatilhos, comandos e versões efetivamente configurados.

## Próximos passos

O roadmap é evolutivo e pode mudar conforme as necessidades do projeto.

- [ ] Consolidar os fluxos de autenticação e autorização.
- [ ] Evoluir a dashboard com dados reais dos módulos.
- [ ] Expandir o gerenciamento de produtos e comandas.
- [ ] Desenvolver a gestão de agenda.
- [ ] Ampliar a cobertura de testes automatizados.
- [ ] Fortalecer os contratos e limites entre módulos.
- [ ] Aprimorar a experiência responsiva do frontend.
- [ ] Evoluir o pipeline de CI e introduzir etapas de entrega contínua.
- [ ] Avaliar containerização com Docker.

## Contribuição

Este repositório é desenvolvido como um projeto de aprendizado e evolução contínua. Sugestões, apontamentos de arquitetura e melhorias são bem-vindos.

Para contribuir:

1. Crie uma branch para sua alteração.
2. Faça commits pequenos e descritivos.
3. Execute build e testes antes de abrir um pull request.
4. Descreva o objetivo da mudança e como validá-la.

## Licença

Nenhuma licença foi especificada neste README. Antes de permitir reutilização, distribuição ou contribuição externa sob termos definidos, adicione um arquivo `LICENSE` e atualize esta seção.

---

Desenvolvido para praticar e aplicar conceitos de engenharia de software em um sistema de gerenciamento de quadras esportivas.
