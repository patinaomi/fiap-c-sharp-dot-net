
# Sistema de Gerenciamento de Fornecedores e Vendedores

Este projeto tem como objetivo implementar um sistema para gerenciar informações de fornecedores e vendedores.

## Funcionalidades
- Gerenciamento de informações de fornecedores e vendedores.
- CRUD (Create, Read, Update, Delete) para fornecedores e vendedores.
- Validação de dados através de anotações.
- Injeção de dependências para serviços e repositórios.
- Documentação da API com Swagger.

## Sumário
1. [Implementação da Aplicação](#implementação-da-aplicação)
2. [Criação das Entidades](#criação-das-entidades)
3. [Implementação do Repositório](#implementação-do-repositório)
4. [Injeção de Dependência](#injeção-de-dependência)
5. [Documentação da API](#documentação-da-api)
6. [Implementação de DTOs](#implementação-de-dtos)
7. [Validação com Annotations](#validação-com-anotações)
8. [Configuração da Conexão](#configuração-da-conexão)

## Implementação da Aplicação

Complete os métodos faltantes nas classes de aplicação para Fornecedor e Vendedor.

## Criação das Entidades

### FornecedorEntity

- **Id**: Identificador único do fornecedor (`int`).
- **Nome**: Nome do fornecedor (`string`).
- **CNPJ**: CNPJ do fornecedor (`string`, campo obrigatório).
- **Endereco**: Endereço do fornecedor (`string`).
- **Telefone**: Telefone de contato do fornecedor (`string`, campo obrigatório).
- **Email**: Email do fornecedor (`string`, campo obrigatório).
- **CriadoEm**: Data de criação do registro (`DateTime`).

### VendedorEntity

- **Id**: Identificador único do vendedor (`int`).
- **Nome**: Nome do vendedor (`string`, campo obrigatório).
- **Email**: Email do vendedor (`string`, campo obrigatório).
- **Telefone**: Telefone de contato do vendedor (`string`, campo obrigatório).
- **DataNascimento**: Data de nascimento do vendedor (`DateTime`).
- **Endereco**: Endereço do vendedor (`string`).
- **DataContratacao**: Data de contratação do vendedor (`DateTime`).
- **ComissaoPercentual**: Percentual de comissão do vendedor (`decimal`).
- **MetaMensal**: Meta mensal do vendedor (`decimal`).
- **CriadoEm**: Data de criação do registro (`DateTime`).

## Implementação do Repositório

Complete os métodos faltantes no repositório, garantindo que todas as operações de CRUD (Create, Read, Update, Delete) estejam implementadas corretamente.

## Injeção de Dependência

Implemente a injeção de dependência para as classes de serviço e repositório. Utilize os frameworks de injeção de dependência adequados para garantir que todas as dependências necessárias sejam corretamente injetadas.

## Documentação da API

Adicione documentação clara e concisa em todos os métodos dos controllers, utilizando Swagger annotations. A documentação deve descrever corretamente cada rota e método disponível na API.

## Implementação de DTOs

Crie e implemente as propriedades necessárias nas classes DTO (Data Transfer Objects) para Fornecedor e Vendedor, garantindo que apenas os dados relevantes sejam transferidos entre as camadas do sistema.

## Validação com Anotações

Implemente as regras de validação utilizando annotations nas classes DTOs. As validações devem garantir que os dados atendam aos seguintes critérios:

- **FornecedorEntity**: CNPJ, Telefone e Email obrigatórios.
- **VendedorEntity**: Nome, Email e Telefone obrigatórios.

## Configuração da Conexão

Adicione a string de conexão necessária no arquivo de configuração da aplicação. Garanta que a aplicação esteja conectada corretamente ao banco de dados, permitindo o acesso e manipulação dos dados de fornecedores e vendedores.

---

## Tecnologias Utilizadas

- **C#**
- **Entity Framework**  (para persistência de dados)
- **ASP.NET Core**
- **Swagger** (para documentação da API)
- **Oracle Database** (banco de dados)

## Como Executar o Projeto

1. Clone o repositório.
2. Configure a string de conexão no arquivo `appsettings.json`.
3. Compile o projeto utilizando o Visual Studio ou outro ambiente de sua escolha.
4. Execute as migrações do banco de dados (caso esteja utilizando Entity Framework).
5. Acesse o Swagger UI na rota `/swagger` para explorar a API.
