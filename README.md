ESX Teste
=====================

O projeto ESX Teste é um projeto realizado para teste de conhecimento para a empresa ESX.

## Pré-requisitos para execução do projeto:
- Visual Studio 2017 versão 15.9 ou posterior
- .NET Core SDK 2.2
- .NET Core Runtime 2.2

[Download .NET Core SDK e Runtime](https://dotnet.microsoft.com/download)

# Tecnologias implementadas

- .NET Core 2.2
- ASP.NET WebApi Core
- Entity Framework Core 2.2.1
- Swagger UI
- AutoMapper
- Microsoft Dependency Injection
- Banco de dados SQL Server
- Docker

# Arquitetura:

- Aplicação de conceitos de separação de responsabiidades, SOLID e Clean Code
- Domain Driven Design (Layers and Domain Model Pattern)
- Repositórios e repositório genérico

# Como executar o projeto usando docker e banco de dados SQL Server da Azure

- Considere que os pré-requisitos listados acima sejam atendidos.
- Deve-se utilizar docker para execução de containers em linux.
- Utilizar o banco de dados online já criado na Azure (connection já está no arquivo .env)
- Escolher o docker-compose como StartUp Project

# Como executar o projeto ESX.Teste.API direto com banco de dados local

- Considere que os pré-requisitos listados acima sejam atendidos.
- Escolher o projeto ESX.Teste.API como StartUp Project.
- Criar um banco de dados vazio com qualquer nome.
- Alterar os arquivos appsettings e adicionar a connectionstring do banco que foi criado.
- Descomentar trecho de código e comentar trecho de código no ESXTesteContext.cs

```C#
optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
```

- Comentar o trecho que é usado somente quando o projeto é executado com o docker:
```C#
//optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));
```
- Acessar o Package Manager Console, setar o projeto ``ESX.Teste.Infra.Data`` como default e executar o comando:

```
Update-Database
```

- Pronto, o projeto está pronto para ser executado.




