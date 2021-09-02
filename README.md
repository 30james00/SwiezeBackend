# First setup
1. ```dotnet user-secrets init -p API/```
2. ```dotnet user-secrets set "PostgreSQL" "Host=localhost; Database=swieze; Username=postgres; Password=swiezeWarzywa" -p API/```
3. ```dotnet-ef database update -p API/```

# Startup
1. ```docker-compose up``` or Rider Configuration
2. Run project
