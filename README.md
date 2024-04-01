# Projeto URL utilizando .NET e PostgreSQL com Docker

Este projeto é uma aplicação de exemplo que gerencia URLs usando .NET para a WebAPI e PostgreSQL para o banco de dados, ambos sendo orquestrados com Docker.

## Funcionalidades

- Adicionar uma nova URL
- Listar todas as URLs cadastradas
- Obter uma URL pelo seu ID
- Atualizar uma URL existente
- Excluir uma URL pelo seu ID

## 🖥️ Tecnologias Utilizadas

- ![.NET](https://img.shields.io/badge/.NET-%235C2D91.svg?style=for-the-badge&logo=.net&logoColor=white) 
- ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)
- ![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)


## Pré-requisitos

- Docker instalado e configurado em seu sistema.
- Conexão à internet (para baixar as imagens necessárias do Docker Hub).

## Instalação

**Passo 1**
- Procure no menu iniciar pelo programa "Powershell" e dê clique direito no ícone para Executar com Administrador. Digite o comando "wsl --install" e pressione Enter. Após instalação, reinicie.

**Passo 2**
- Baixar e instalar as atualizações para o kernel Linux.
Link: [Install -Update Kernel Linux](https://www.youtube.com/redirect?event=video_description&redir_token=QUFFLUhqbWQ2UFVUMy1JWGk2cjI4LV9iUUZWWW5DTjVJUXxBQ3Jtc0ttemh3b2lTZ2VyNlI3d2o3OWZwYk5lLWk1MTJpa3NWcEZYdHJRQndDNlRPVmw0TGJFM1B2V1NyOXl4d3Y3UFRpMGR3OFFQdWVQSXNZS1JHb2RrbFVaQjkyclNvS1d1Y3F1SjdHVUNmTUFsX0swVFVQSQ&q=https%3A%2F%2Fwslstorestorage.blob.core.windows.net%2Fwslblob%2Fwsl_update_x64.msi&v=kh1gkqCrNx4)

**Passo 3**
- Baixar e instalar o Docker Desktop. Após instalação, reinicie.
Link: [Install Docker Desktop](https://docs.docker.com/desktop/install/windows-install/)

## Clonar e Execução

1. **Clone este repositório:**

```bash
git clone https://github.com/ArthurCovelo/Projeto_Urls_Radix_1.git
```
2. **Execute o comando Docker Compose para construir e iniciar os serviços:**
```bash
docker-compose up
```

Este comando criará e iniciará os containers para o banco de dados PostgreSQL e a WebAPI. 
Além disso, as tabelas serão criadas automaticamente usando os scripts SQL fornecidos..
Após a execução bem-sucedida do comando docker-compose up, a API estará disponível no seguinte endereço:

http://localhost:8081/swagger/index.html

Acesse este endereço padrão em seu navegador para visualizar a documentação interativa da API (Swagger).

## Encerrando a execução
Para encerrar a execução dos containers, pressione Ctrl + C no terminal onde você executou o docker-compose up. Isso encerrará os containers em execução.

## Conferir as images.
```bash
docker images
```
## Conferir se o container está em execução.
```bash
docker ps
```
## Para remover todos os containers
```bash
docker container prune
```

