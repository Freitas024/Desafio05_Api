# 🚀 Desafio 05 - Minha Primeira API com C# (.NET)

<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/Freitas024/Desafio05_Api?color=%23512BD4">
  <img alt="Repository size" src="https://img.shields.io/github/repo-size/Freitas024/Desafio05_Api">
</p>

## 💻 Sobre o projeto

Este projeto é uma introdução ao desenvolvimento Backend com **C# e .NET**, utilizando o conceito de **Minimal APIs**.

O objetivo principal deste desafio foi explorar a semelhança entre o **Express.js (Node)** e as novas **Minimal APIs do .NET**, criando endpoints leves e rápidos sem a complexidade dos antigos Controllers.

Atualmente, o projeto simula um banco de dados em memória utilizando uma estrutura de dados estática (`static List<Usuario>`), focando no entendimento de:
* Roteamento (Routes)
* Retorno de dados em JSON
* Tipagem forte do C# aplicada a APIs

## 🛠 Tecnologias

- **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**
- **[.NET 8](https://dotnet.microsoft.com/)** (Web API)
- **Minimal API** (Estrutura simplificada)

## ✨ Funcionalidades Atuais

- [x] **Banco de Dados em Memória:** Simulação de persistência usando Lista Estática (`List<Usuario>`).
- [x] **Listagem de Usuários:** Endpoint para retornar todos os registros.
- [x] **Busca por ID:** Endpoint dinâmico para localizar um usuário específico.
- [ ] **Próximos passos:** Implementar verbos POST e PUT para manipulação dos dados.

## 🚀 Como executar o projeto

### Pré-requisitos
Você precisa ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# Clone este repositório
$ git clone [https://github.com/Freitas024/Desafio05_Api.git](https://github.com/Freitas024/Desafio05_Api.git)

# Acesse a pasta do projeto
$ cd Desafio05_Api

# Execute a aplicação
$ dotnet run

# O servidor iniciará (geralmente em http://localhost:5000 ou similar)
# Verifique o terminal para a porta correta.
