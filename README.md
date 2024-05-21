<h1 align="center">
  Petfolio
</h1>

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Static Badge](https://img.shields.io/badge/MIT-maker?style=for-the-badge&label=License&labelColor=%23303030&color=%23808080)

Petfolio é uma API básica de CRUD, sem persistência de dados, desenvolvida com o intuito de aplicar uma arquitetura mais "clean". A estrutura é dividida em camadas, cada uma contendo sua lógica específica.

## Como usar
Faça um clone do projeto.

### Visual Studio
Basta abrir o projeto no Visual Studio e executar a aplicação.

### VS Code
Navegue até `src/Petfolio.API` e execute o comando `dotnet run`.

## API Endpoints

|Rota  | Descrição |
|--|--|
| <kbd>GET /api/Pet</kbd> | Recupera todos os pets  |
| <kbd>GET /api/Pet/{id}</kbd> | Recupera um pet |
| <kbd>POST /api/Pet</kbd> | Cadastra um pet |
| <kbd>DELETE /api/Pet/{id}</kbd> | Deleta um pet |
| <kbd>PUT /api/Pet/{id}</kbd> | Atualiza um pet |

Para visualizar a documentação completa dos endpoints, rode o projeto e acesse a rota: `localhost{PORT}/swagger/index.html`.