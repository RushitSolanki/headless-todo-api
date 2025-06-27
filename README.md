# 🚀 Headless TODO API

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue.svg)](https://dotnet.microsoft.com/apps/aspnet)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-15-blue.svg)](https://www.postgresql.org/)
[![Docker](https://img.shields.io/badge/Docker-Enabled-blue.svg)](https://www.docker.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A production-ready headless TODO API built with **ASP.NET Core 8**, **PostgreSQL**, and **JWT authentication**. Features Docker support, Swagger documentation, and Clean Architecture patterns.

## ✨ Features

- 🔐 **Complete CRUD Operations** for TODO management
- 🗄️ **PostgreSQL Database** with Entity Framework Core
- 🐳 **Docker Containerization** with PostgreSQL & Redis
- 📚 **Swagger/OpenAPI Documentation**
- 🏗️ **Clean Architecture** implementation
- 🔒 **JWT Authentication** (ready for implementation)
- 🧪 **Comprehensive Testing** framework
- ⚡ **High Performance** with async operations
- 🔧 **Development-friendly** with hot reload

## 🛠️ Tech Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| **ASP.NET Core** | 8.0 | Web API framework |
| **PostgreSQL** | 15 | Primary database |
| **Entity Framework Core** | 8.0 | ORM and migrations |
| **Docker** | Latest | Containerization |
| **Redis** | 7-alpine | Caching (future) |
| **Swagger/OpenAPI** | Latest | API documentation |
| **xUnit** | Latest | Unit testing |

## 🚀 Quick Start

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [Git](https://git-scm.com/)

### 1. Clone the Repository
```bash
git clone https://github.com/RushitSolanki/headless-todo-api.git
cd headless-todo-api
```

### 2. Start with Docker (Recommended)

You can run each step individually:

**Start PostgreSQL and Redis containers:**
```bash
docker-compose up -d postgres redis
```

**Run database migrations:**
```bash
cd TodoApp.API
dotnet ef database update
```

**Start the API:**
```bash
dotnet run
```

### 3. Access the Application
- **API Base URL**: http://localhost:5235
- **Swagger UI**: http://localhost:5235/swagger
- **Health Check**: http://localhost:5235/health

## 📖 API Documentation

### Base URL
```
http://localhost:5235/api/v1
```

### Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/todos` | Get all TODOs |
| `GET` | `/todos/{id}` | Get TODO by ID |
| `POST` | `/todos` | Create new TODO |
| `PUT` | `/todos/{id}` | Update TODO |
| `DELETE` | `/todos/{id}` | Delete TODO |

### Example Usage

#### Create a TODO

**Using Swagger UI (Recommended)**
1. Open your browser and go to: http://localhost:5235/swagger
2. Find the POST `/api/v1/todos` endpoint
3. Click "Try it out"
4. Enter the JSON data in the request body:
```json
{
  "title": "Complete API Documentation",
  "description": "Write comprehensive API docs",
  "priority": 1,
  "userId": "12345678-1234-1234-1234-123456789012"
}
```
5. Click "Execute"

#### Get All TODOs
1. Open your browser and go to: http://localhost:5235/swagger
2. Find the GET `/api/v1/todos` endpoint
3. Click "Try it out"
4. Click "Execute"

#### Get TODO by ID
1. Open your browser and go to: http://localhost:5235/swagger
2. Find the GET `/api/v1/todos/{id}` endpoint
3. Click "Try it out"
4. Enter the TODO ID in the `id` parameter
5. Click "Execute"

#### Update a TODO
1. Open your browser and go to: http://localhost:5235/swagger
2. Find the PUT `/api/v1/todos/{id}` endpoint
3. Click "Try it out"
4. Enter the TODO ID in the `id` parameter
5. Enter the updated data in the request body:
```json
{
  "title": "Updated API Documentation",
  "description": "Updated comprehensive API docs",
  "priority": 2,
  "status": 1,
  "dueDate": "2025-12-31T23:59:59Z"
}
```
6. Click "Execute"

#### Delete a TODO
1. Open your browser and go to: http://localhost:5235/swagger
2. Find the DELETE `/api/v1/todos/{id}` endpoint
3. Click "Try it out"
4. Enter the TODO ID in the `id` parameter
5. Click "Execute"

### Priority Values
- `0` = Low
- `1` = Medium
- `2` = High

### Status Values
- `0` = Pending
- `1` = InProgress
- `2` = Completed

## 🏗️ Project Structure

```
TodoApp/
├── 📁 TodoApp.API/              # Web API project
│   ├── 📁 Controllers/          # API controllers
│   ├── 📁 Properties/           # Launch settings
│   ├── 📄 Program.cs            # Application entry point
│   └── 📄 appsettings.json      # Configuration
├── 📁 TodoApp.Core/             # Domain layer
│   ├── 📁 Models/               # Domain entities
│   └── 📁 Interfaces/           # Repository interfaces
├── 📁 TodoApp.Infrastructure/   # Data access layer
│   ├── 📁 Migrations/           # EF Core migrations
│   └── 📄 TodoAppDbContext.cs   # Database context
├── 📁 TodoApp.Tests/            # Test projects
├── 📄 docker-compose.yml        # Docker services
├── 📄 Dockerfile                # Application container
└── 📄 README.md                 # This file
```

## 🔧 Configuration

### Environment Variables
```bash
# Database
ConnectionStrings__DefaultConnection=Host=localhost;Port=5433;Database=todoapp;Username=postgres;Password=password

# Redis (for future caching)
ConnectionStrings__Redis=localhost:6379
```

### Docker Configuration
The application uses Docker Compose for easy development setup:
- **PostgreSQL**: Port 5433
- **Redis**: Port 6379
- **API**: Port 5235

## 🧪 Testing

### Run Tests
```bash
# Run all tests
dotnet test

# Run specific test project
dotnet test TodoApp.Tests/

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Test Coverage
- Unit tests for business logic
- Integration tests for API endpoints
- Database tests with in-memory provider

## 🚀 Deployment

### Docker Deployment
```bash
# Build and run with Docker Compose
docker-compose up --build

# Production build
docker build -t todo-api .
docker run -p 5000:80 todo-api
```

### Manual Deployment
1. Build the application: `dotnet publish -c Release`
2. Deploy to your preferred hosting platform
3. Configure environment variables
4. Run database migrations

## 🤝 Contributing

We welcome contributions! Please feel free to submit a Pull Request.

### Development Workflow
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Code Style
- Follow C# coding conventions
- Use meaningful commit messages
- Add tests for new features
- Update documentation as needed

## 📋 Roadmap

### ✅ Completed
- [x] Basic CRUD operations
- [x] PostgreSQL integration
- [x] Docker containerization
- [x] Swagger documentation
- [x] Clean Architecture setup

### 🔄 In Progress
- [ ] JWT Authentication
- [ ] Input validation
- [ ] Unit and integration tests
- [ ] Advanced filtering and search

### 📅 Planned
- [ ] Redis caching
- [ ] Rate limiting
- [ ] Email notifications
- [ ] File attachments
- [ ] API versioning
- [ ] Performance monitoring

## 🐛 Troubleshooting

### Common Issues

#### Database Connection Failed
```bash
# Check if PostgreSQL is running
docker ps | grep postgres

# Restart containers
docker-compose down
docker-compose up -d postgres redis
```

#### Port Already in Use
```bash
# Check what's using the port
lsof -i :5235

# Kill the process or change the port in launchSettings.json
```

#### Migration Errors
```bash
# Remove existing migrations and recreate
dotnet ef migrations remove --project TodoApp.Infrastructure --startup-project TodoApp.API
dotnet ef migrations add InitialCreate --project TodoApp.Infrastructure --startup-project TodoApp.API
```

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) for the amazing framework
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) for data access
- [PostgreSQL](https://www.postgresql.org/) for the reliable database
- [Docker](https://www.docker.com/) for containerization
- [Swagger](https://swagger.io/) for API documentation

## 📞 Support

- **Issues**: [GitHub Issues](https://github.com/RushitSolanki/headless-todo-api/issues)
- **Discussions**: [GitHub Discussions](https://github.com/RushitSolanki/headless-todo-api/discussions)

---

⭐ **Star this repository if you found it helpful!**
