# 🍳 MyRecipeBook (Livro de Receitas)

API para gerenciamento de receitas culinárias desenvolvida em **.NET (C#)**, estruturada seguindo os princípios de **Clean Architecture** (Arquitetura Limpa) e **Domain-Driven Design (DDD)**.

---

## 🚀 Tecnologias e Ferramentas

- **[.NET](https://dotnet.microsoft.com/)** (C#)
- **ASP.NET Core Web API**
- **Swagger / OpenAPI** (Documentação da API)
- **Clean Architecture & DDD**
- **xUnit / FluentAssertions** (Testes automatizados)

---

## 🏛️ Estrutura do Projeto

A solução está organizada em camadas para garantir baixo acoplamento e alta coesão:

```text
MyRecipeBook/
├── src/
│   ├── Backend/
│   │   ├── MyRecipeBook.Api/              # Camada de Apresentação (Controllers, Swagger, DI)
│   │   ├── MyRecipeBook.Aplication/       # Casos de Uso (Use Cases, DTOs, Mappings)
│   │   ├── MyRecipeBook.Domain/           # Regras de Negócio (Entidades, Interfaces de Repositório)
│   │   └── MyRecipeBook.Infrastructure/   # Acesso a Dados, Banco de Dados, Serviços Externos
│   └── Shared/                            # Comunicação e Recursos Compartilhados
└── tests/                                 # Testes Unitários e de Integração
```

---

## ⚙️ Como Executar o Projeto Localmente

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado
- IDE de sua preferência ([Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/) ou [Rider](https://www.jetbrains.com/rider/))
- [Git](https://git-scm.com/)

### Passo a passo

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/Fabio-Barboza-Silva/MyRecipeBook.git
   cd MyRecipeBook
   ```

2. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```

3. **Compile o projeto:**
   ```bash
   dotnet build
   ```

4. **Execute a API:**
   ```bash
   dotnet run --project src/Backend/MyRecipeBook.Api
   ```

5. **Acesse o Swagger:**
   Abra o navegador e acesse a documentação interativa em:
   `https://localhost:<porta>/swagger`

---

## 🧪 Testes

Para executar todos os testes da solução:

```bash
dotnet test
```

---

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

