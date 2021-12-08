# Swieze.pl Backend

![example workflow](https://github.com/30james00/swiezebackend/actions/workflows/dotnet.yml/badge.svg)

<img src="https://cdn.discordapp.com/attachments/822513310255677460/886696316766392330/marchew.png" height="200" alt="logo swieze">

# First setup
1. ```dotnet user-secrets init -p API/```
2. ```dotnet user-secrets set "ConnectionStrings:PostgreSQL" "Host=localhost; Database=swieze; Username=postgres; Password=swiezeWarzywa" -p API/```
3. ```dotnet user-secrets set "TokenKey" "very secur password" -p API/```
4. Setup Cloudinary  
   ```type .\input.json | dotnet user-secrets set -p API/```
   ```cat ./input.json | dotnet user-secrets set -p API/```
5. Stripe  
```dotnet user-secrets set "Stripe" "<StripeSecretKey>" -p Api```


# Startup
1. ```docker-compose up``` or Rider Configuration
2. Run project

# Testing
1. ```dotnet user-secrets init -p Application.IntegrationTests/```
2. ```dotnet user-secrets set "ConnectionStrings:PostgreSQL" "Host=localhost; Database=swiezeTest; Username=postgres; Password=swiezeWarzywa" -p Application.IntegrationTests/```
3. ```dotnet user-secrets set "TokenKey" "very secur password" -p Application.IntegrationTests/```
4. ```dotnet test``` or your run tests in your IDE
5. Setup Cloudinary  
```type ./input.json | dotnet user-secrets set -p Application.IntegrationTests```
```cat ./input.json | dotnet user-secrets set -p Application.IntegrationTests```
6. Stripe  
   ```dotnet user-secrets set "Stripe" "<StripeSecretKey>" -p Application.IntegrationTests```
