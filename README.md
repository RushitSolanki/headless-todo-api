# Headless TODO API

This is a modern, headless TODO application backend built with ASP.NET Core 8, PostgreSQL, and Docker. It follows Clean Architecture principles and is designed for rapid, secure, and scalable development.

## Features
- RESTful API with full CRUD for TODOs
- PostgreSQL with Entity Framework Core
- JWT authentication (ASP.NET Core Identity)
- Dockerized for easy deployment
- Redis caching (future phase)
- Comprehensive testing (xUnit)
- Swagger/OpenAPI documentation

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [PostgreSQL](https://www.postgresql.org/) (optional, for local dev)

### Development Setup
1. Clone the repository
2. Build and run with Docker Compose:
   ```sh
   docker-compose up --build
   ```
3. The API will be available at `http://localhost:5000`

### Manual Local Run
1. Update `appsettings.Development.json` with your PostgreSQL connection string
2. Run database migrations:
   ```sh
   dotnet ef database update --project TodoApp.Infrastructure --startup-project TodoApp.API
   ```
3. Start the API:
   ```sh
   dotnet run --project TodoApp.API
   ```

### Project Structure
```
TodoApp/
├── TodoApp.API/          # Web API project
├── TodoApp.Core/         # Domain models & interfaces
├── TodoApp.Infrastructure/ # Data access & external services
├── TodoApp.Tests/        # Unit & integration tests
```

## Configuration
- Default PostgreSQL: `Host=localhost;Database=todoapp;Username=postgres;Password=password`
- Change via environment variables or `appsettings.json`

## Useful Commands
- Run tests: `dotnet test`
- Add migration: `dotnet ef migrations add <Name> --project TodoApp.Infrastructure --startup-project TodoApp.API`
- Update DB: `dotnet ef database update --project TodoApp.Infrastructure --startup-project TodoApp.API`

## License
MIT
