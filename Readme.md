## Financial Office System

Financial Office System is a layered ASP.NET Core 9.0 solution with a domain layer, application contracts, infrastructure persistence, and a web API host.

### Solution Structure

- `src/core.Api` - Web API startup project
- `src/core.Application` - Application interfaces and contracts
- `src/core.Domain` - Domain entities
- `src/core.Infrastructure` - EF Core, repositories, unit of work, and dependency injection


### Requirements

- .NET 9 SDK
- SQL Server Express or another SQL Server instance
- EF Core tools (`dotnet-ef`)

### Configuration

The API uses the connection string in [src/core.Api/appsettings.json](src/core.Api/appsettings.json).



### Run The Application

Restore and build:

```bash
dotnet restore
dotnet build src/core.Api/core.Api.csproj
```

Run the API:

```bash
dotnet run --project src/core.Api/core.Api.csproj
```

### Database Migrations

Create a migration:

```bash
dotnet-ef migrations add InitialCreate --project src/core.Infrastructure/core.Infrastructure.csproj --startup-project src/core.Api/core.Api.csproj --context AppDbContext --output-dir Persistence/Migrations
```

Update the database:

```bash
dotnet-ef database update --project src/core.Infrastructure/core.Infrastructure.csproj --startup-project src/core.Api/core.Api.csproj --context AppDbContext
```

### Architecture Notes

- EF Core mapping is configured with fluent configuration classes under `src/core.Infrastructure/Persistence/Configurations`.
- Repositories expose basic CRUD operations through a generic base repository.
- `UnitOfWork` coordinates the repositories and commits changes through a single `SaveChangesAsync` call.
- Dependency injection is registered through `core.Infrastructure.DependencyInjection.AddInfrastructure(...)`.
