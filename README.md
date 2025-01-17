# API CRUD de trabalhadores

Este projeto é uma aplicação distribuída que implementa uma API RESTful utilizando os conceitos fundamentais de sistemas distribuídos. O sistema foi projetado para ser executado em containers Docker e está documentado para facilitar seu uso.

---

## Informações Acadêmicas

- **Unidade Curricular**: Serviços Distribuídos
- **Professor**: Wenderson Wanzeller
- **Aluno**: António Tomé Pereira Ferreira
- **Matrícula**: 32191
- **Ano Letivo**: 2024/2025
- **Instituição de Ensino**: Instituto Politécnico de Viana do Castelo

---

## Funcionalidades

- API RESTful com suporte aos métodos HTTP: GET, POST, PUT, DELETE.
- Versionamento do código no GitHub com branches para desenvolvimento e produção.
- Imagem Docker publicada no Docker Hub.
- Documentação da API no arquivo API.md.
- Arquivo de coleção do Postman disponível no repositório.

---

## Requisitos

Para executar este sistema, você precisará dos seguintes itens instalados:

- Docker (versão atualizada).
- Git.
- Postman (opcional, para testar as rotas da API).

---

# Como Executar

## Passo 1: Clonar o Repositório

Execute o comando abaixo para clonar o repositório do GitHub:

```
git clone https://github.com/tome-ferreira/TP_SISTEMAS_DISTRIBUIDOS_32191.git
```

Acesse o diretório do projeto:

```
cd TP_SISTEMAS_DISTRIBUIDOS_32191
```

---

## Passo 2: Executar a Aplicação com Docker

Certifique-se de que o Docker está em execução.

### Na primeira execução:

Execute o comando:
```
docker-compose build
```

Depois execute:
```
docker-compose up
```

Agora pare a aplicação utilizando [Ctrl + C].

Por fim execute novamente o comando 

```
docker-compose up
```

A interface do Swagger para testar a API está agora dísponivel em http://localhost:5003/swagger

A aplicação está disponível no endereço: http://localhost:5003.

### Nas seguintes execuções:

#### Para production:

Execute o comando:

```
docker-compose -f docker-compose.prod.yml up
```
A interface do Swagger para testar a API está agora dísponivel em http://localhost:5003/swagger

A aplicação está disponível no endereço: http://localhost:5003.

#### Para development:

Execute o comando:

```
docker-compose up
```
A interface do Swagger para testar a API está agora dísponivel em http://localhost:5003/swagger

A aplicação está disponível no endereço: http://localhost:5003.

O PgAdmin para gerir a base de dados está disponível em http://localhost:5050. Para conectar ao PgAdmin utilize os seguintes dados:

```
Username: admin@admin.com
Password: admin
```
Depois selecione [New server] e introduza os seguintes dados:

```
Host: postgresDb
Username: postgres
Password: RenaultClio19d
```



---

### Passo 3: Testar as Rotas da API

A API pode ser testada utilizando ferramentas como o Postman ou usando o Swagger disponível atrvés de http://localhost:5003/swagger. Todas as rotas e detalhes de requisição estão documentados no arquivo API.md. 

---

## Imagem Docker

A imagem Docker da aplicação foi publicada no Docker Hub e pode ser baixada diretamente com o comando:
```
docker pull tomeferreira/tp-sistemas-distribuidos-api
````

---

## Estrutura do Repositório

```
| TP_SISTEMAS_DISTRIBUIDOS_V5
| | bin
| | Controllers
| | Data
| | | ApplicationDbContext.cs
| | Entities
| | | Worker.cs
| | Migrations
| | | 20250116221410_Initial,cs
| | | ApplicationDbContextModelSnapshot.cs
| | Properties
| | | lauchSettings.json
| | MigrationService.cs
| | Program.cs
| | TP_SISTEMAS_DISTRIBUIDOS_V5.csproj
| | TP_SISTEMAS_DISTRIBUIDOS_V5.http
| | WorkerEndpoints
| API.md
| .dockerignore
| docker-compose.prod.yml
| docker-compose.yml
| Dockerfile
| TP_SISTEMAS_DISTRIBUIDOS_V5.sln
| README.md
```
---

## Licença

Este projeto está licenciado sob a Licença MIT. 