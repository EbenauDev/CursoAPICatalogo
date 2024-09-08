## Antes de executar o projeto verifique se possui instalado no seu ambiente o dotnet-ef


## Comandos do EF Core Tools
``dotnet ef``

- Cria o script de migração
``dotnet ef migrations add "nome"``

- Remove o script de migração
- ``dotnet ef migrations remove "nome"``

- Gera o banco de dados e as tabelas com base no script
- ``dotnet ef database update``


## Alternativa para aplicar o Migrations (Package Manager Console)
- Cria o script de migração
``add-migration "nome"``

- Remove o script de migração
- ``remove-migration "nome"``

- Gera o banco de dados e as tabelas com base no script
- ``update-database``