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
- Enviar o IP para liberação no firewall do banco na Azure.
- Colocar a connection string do banco de dados Azure no arquivo .env
- Escolher o docker-compose como StartUp Project

# Como executar o projeto ESX.Teste.API direto com banco de dados local

- Considere que os pré-requisitos listados acima sejam atendidos.
- Escolher o projeto ESX.Teste.API como StartUp Project.
- Criar um banco de dados vazio com qualquer nome.
- Alterar os arquivos appsettings e adicionar a connectionstring do banco que foi criado. (src/ESX.Teste.API/appsettings.json e src/ESX.Teste.Infra.Data/appsettings.json).

- Acessar o Package Manager Console, setar o projeto ``ESX.Teste.Infra.Data`` como default e executar o comando:

```
Update-Database
```

- Pronto, o projeto está pronto para ser executado.

# Hospedagem

- A aplicação foi hospedada no Azure WebApp for Container 
- URL: https://esxteste.azurewebsites.net


## Serviços da Azure Utilizados
 - Azure Container Registry (armazenamento e gerenciamento da imagem)
 - SQL Server (PaaS - Platform-as-a-Service)
 - WebApp for Containers (Serviço para execução de aplicativos em container, escalável de forma manual ou automática)
 - Deploy automatizado junto ao Azure Container Registry, assim que uma imagem nova é enviada.





