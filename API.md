
# Documentação da API

## Endpoint: Listar Todos os Trabalhadores
- **URL**: `/api/Worker`
- **Método**: `GET`
- **Descrição**: Retorna uma lista de todos os trabalhadores existentes na base de dados.

### Response:
- **Sucesso (200 OK)**:
```json
[
  {
    "id": 1,
    "name": "João",
    "surname": "Silva",
    "department": "Recursos Humanos",
    "internalNumber": 123,
    "dateOfBirth": "1980-05-15T00:00:00"
  },
  {
    "id": 2,
    "name": "Maria",
    "surname": "Sousa",
    "department": "TI",
    "internalNumber": 456,
    "dateOfBirth": "1990-11-25T00:00:00"
  }
]
```

---

## Endpoint: Obter Trabalhador pelo Id
- **URL**: `/api/Worker/{id}`
- **Método**: `GET`
- **Descrição**: Retorna os detalhes de um trabalhador em especifico com base no Id fornecido.

### Entrada (Parâmetros de URL):
- **id**: Id do trabalhador a ser retornado.

### Saída (Response):
- **Sucesso (200 OK)**:
```json
{
  "id": 1,
  "name": "João",
  "surname": "Silva",
  "department": "Recursos Humanos",
  "internalNumber": 123,
  "dateOfBirth": "1980-05-15T00:00:00"
}
```
- **Erro (404 Not Found)**:
Não retorna nenhum conteúdo.



---

## Endpoint: Criar Trabalhador
- **URL**: `/api/Worker`
- **Método**: `POST`
- **Descrição**: Adiciona um trabalhador à base de dados.

### Entrada (Request Body):
```json
{
  "name": "João",
  "surname": "Silva",
  "department": "Recursos Humanos",
  "internalNumber": 123,
  "dateOfBirth": "1980-05-15T00:00:00"
}
```

### Response:
- **Sucesso (201 Created)**:
```json
{
  "id": 1,
  "name": "João",
  "surname": "Silva",
  "department": "Recursos Humanos",
  "internalNumber": 123,
  "dateOfBirth": "1980-05-15T00:00:00"
}
```
- **Erro (500 Internal Server error)**: (Quando um trabalhador com o Id definido já existe).
Não retorna nenhum conteúdo.

---

## Endpoint: Atualizar Trabalhador
- **URL**: `/api/Worker/{id}`
- **Método**: `PUT`
- **Descrição**: Atualiza os dados de um trabalhador existente.

### Entrada (Parâmetros de URL e Request Body):
- **id**: Id do trabalhador a ser atualizado.
- **Body**:
```json
{
  "id": 1,
  "name": "João Atualizado",
  "surname": "Silva Atualizado",
  "department": "Financeiro",
  "internalNumber": 789,
  "dateOfBirth": "1980-05-15T00:00:00"
}
```

### Response:
- **Sucesso (200 OK)**
Não retorna nenhum conteúdo.

- **Erro (404 Not Found)**:
Não retorna nenhum conteúdo.


---

## Endpoint: Apagar Trabalhador
- **URL**: `/api/Worker/{id}`
- **Método**: `DELETE`
- **Descrição**: Remove um trabalhador da base de dados.

### Entrada (Parâmetros de URL):
- **id**: Id do trabalhador a ser removido.

### Saída (Response):
- **Sucesso (200 OK)**
Não retorna nenhum conteúdo.
- **Erro (404 Not Found)**:
Não retorna nenhum conteúdo.


---

