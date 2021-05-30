# First setup
1. ```cd SwiezeBackend``` 
2. ```dotnet user-secrets init```
3. ```dotnet user-secrets set "PostgreSQL" Host=localhost; Database=swieze; Username=postgres; Password=swiezeWarzywa"```

# Startup
1. ```docker-compose up```
2. ```cd SwiezeBackend```
3. ```dotnet-ef database update```
4. Run project
