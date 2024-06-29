
## don net core Minimal CRUD API APP DEMO

## MS Link 
  https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio-code


## Entity Framework Core and MySQL Packages
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Pomelo.EntityFrameworkCore.MySql

## Testing UI
    dotnet add package NSwag.AspNetCore // for testing Ui

## Dotnet Tools
    https://learn.microsoft.com/en-us/ef/core/cli/dotnet
    dotnet tool update --global dotnet-ef // one time install
    dotnet add package Microsoft.EntityFrameworkCore.Design // added in every project

## Database migrations
    dotnet ef migrations add InitialCreate 
    dotnet ef database update



## Links
    https://www.daveops.co.in/post/code-first-entity-framework-core-mysql
    https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio-code
    https://www.youtube.com/watch?v=iceJBFcWuM4

## GitHub Pushing
    dotnet new gitignore

    git add .
    git commit -m 'Initial Uploads'
    git branch -M main
    git push -u -f origin main