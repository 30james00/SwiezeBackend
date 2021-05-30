# Setup
1. ```cd SwiezeBackend``` 
2. ```dotnet user-secrets init```
3. Create swieze_postgres.txt with PostgresSQL password.
4. ```dotnet user-secrets set "PostgreSQL" "<<conention-string>>"```
5. ```docker swarm init```
6. ```sudo docker stack deploy --compose-file=./docker-compose.yml swieze```
7. ```dotnet-ef database update```
8. Run project

connection-string = ```"Host=localhost; Database=swieze; Username=postgres; Password={chosen password}"```