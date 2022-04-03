# Apontamento AspNetCore

Projeto AspNetCore para apontamento de tarefas.

## Rodando o projeto

### Visual Studio

Defina como projeto para inicialização o projeto `Apontamento` e rode o projeto.

### Visual Studio Code

Para rodar o projeto no Visual Studio Code, basta abrir o projeto e na aba "Run and Debug" selecione e rode a opção `.NET Core Launch (web)`.

Obs.: Pode ser uma boa ideia instalar as extensões recomendadas que o vscode irá sugerir.

### Docker

Caso queira rodar o projeto com o docker, existe um arquivo docker compose para facilitar a execução.

Com o docker instalado, para iniciar o projeto utilize o comando abaixo na pasta raiz do projeto:

```bash
docker-compose up -d
```

E para parar a execução do projeto com o docker, utilize o comando:

```bash
docker-compose down
```

### Observações

Caso queira utilizar outra connection string quando estiver rodando o projeto pelo Visual Studio ou Visual Studio Code, você pode definir um `user-secret` para o projeto Apontamento utilizando o dotnet-cli com os comandos abaixo a partir da pasta raiz do projeto:

```bash
# Movendo para a pasta raiz do projeto
cd Apontamento

# Definindo a connection string (altere as propriedades para o seu caso)
dotnet user-secrets set 'ConnectionStrings:DefaultConnection' 'Server=<SEU_SERVER>,<PORTA>;Database=aspnet-Apontamento;User Id=<USER_NAME>;Password=<SENHA>'
```

<!-- ## License -->
<!-- TODO: Adicionar licensa... talvez essa https://pt.wikipedia.org/wiki/Beerware -->
