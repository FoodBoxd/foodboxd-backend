# ⚙️ foodboxd-backend

Este é o repositório do backend do projeto **Foodboxd**, construído com **ASP.NET Core Web API** e **Entity Framework Core (EF Core)**.

Ele é responsável por gerenciar a lógica de negócios, a comunicação com o banco de dados MySQL e a exposição da API REST para o frontend.

## 🚀 Tecnologias e Dependências

* **Plataforma:** .NET 8 (ou superior)
* **Framework:** ASP.NET Core Web API
* **ORM:** Entity Framework Core
* **Banco de Dados:** MySQL
* **Driver MySQL:** Pomelo.EntityFrameworkCore.MySql
* **Gerenciamento de Pacotes:** .NET CLI

## 🛠️ Pré-requisitos

Para rodar o back, você precisa ter

1.  **SDK do .NET 8** (ou a versão mais recente).
2.  **Servidor MySQL** (MySQL Workbench como conhecemos com servidor rodando).
3.  A ferramenta de linha de comando do EF Core: `dotnet tool install --global dotnet-ef` (se ainda não estiver instalada).

## ⚙️ Configuração do Banco de Dados

### 1 String de Conexão

O projeto usa a abordagem **Code First** do EF Core e se conecta a um banco de dados MySQL chamado **`foodboxd`**.
Isso significa que você **NUNCA DEVE FAZER ALTERAÇÔES DE ESTRUTURA DIRETAMENTE NO MYSQL WORKBENCH**.

Você deve configurar sua string de conexão no arquivo **`appsettings.Development.json`**. Altere o valor de `Password` para a senha do seu usuário `root` (ou o que você configurou no servidor do MySQL):

```json
"ConnectionStrings": {
  "AppDbConnectionString": "server=localhost; database=foodboxd; User=root; Password=SENHA"
}
```

### 2 Migrações para o banco

O banco de dados deve ser criado e atualizado com o esquema (tabelas e colunas) definido nas classes do C#. Execute os seguintes comandos:

a. Restaurar pacotes NuGet:

```bash
dotnet restore
```

b. Criar e atualizar o banco:

```bash
dotnet ef database update
```

### 3 Inicie o back

```bash
dotnet run
```

Se essa etapa gerar algum erro, rode este comando e verifique com o grupo, internet ou IA o motivo dos erros apontados.
```bash
dotnet build
```