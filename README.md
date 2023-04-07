# AromaVilla
A Sample N-layered .NET Core Project Demonstrating Clean Architecture and the Generic Reposityory Pattern

## Packages

## ApplicationCore
```
Install-Package Ardalis.Specification -v 6.1.0
```

### Infrastructure
```
Install-Package Microsoft.EntityFrameworkCore -v 6.0.15
Install-Package Microsoft.EntityFrameworkCore.Tools -v 6.0.15
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -v 6.0.8
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.15
Install-Package Microsoft.EntityFrameworkCore.Design -v 6.0.15
Install-Package Ardalis.Specification.EntityFrameworkCore  -v 6.1.0
```

### Web
```
Install-Package Microsoft.EntityFrameworkCore.Tools -v 6.0.15
```

### Unit-Tests
```
Install-Package Moq
```

### Migrations
Before running the following commands, make sure that "Web" is set as startup project. Run the following 
commands on the projects "Infrastructure"

### Infrastructure
```
Add-Migration InitialCreate -context ShopContext -OutputDir Data/Migrations
Update-Database -context ShopContext
```

```
Add-Migration InitialIdentity -context AppIdentityDbContext -OutputDir Identity/Migrations
Update-Database -context AppIdentityDbContext
```

```
Add-Migration BasketAdded -Context ShopContext -OutputDir Data/Migrations
Update-Database -Context ShopContext
```

## Resources
* https://gist.github.com/yigith/c6f999788b833dc3d22ac6332a053dd1
* https://codepen.io/yigith/pen/PoOrWjX
* https://getbootstrap.com/docs/5.1/examples/checkout/

## önceki migrationa geri dönme
```
update-database InitialCreate -context ShopContext

bu döndüðümüz migrationu silme
remove-migration -context ShopContext
```

