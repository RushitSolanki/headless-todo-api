# Contributing to Headless TODO API

Thank you for your interest in contributing to the Headless TODO API! This document provides guidelines and information for contributors.

## 🤝 How to Contribute

### Reporting Bugs
- Use the [GitHub Issues](https://github.com/YOUR_USERNAME/todo-api-dotnet/issues) page
- Include detailed steps to reproduce the bug
- Provide error messages and stack traces
- Mention your environment (OS, .NET version, etc.)

### Suggesting Features
- Use the [GitHub Discussions](https://github.com/YOUR_USERNAME/todo-api-dotnet/discussions) page
- Describe the feature and its benefits
- Consider implementation complexity
- Check if it aligns with project goals

### Code Contributions
1. Fork the repository
2. Create a feature branch: `git checkout -b feature/amazing-feature`
3. Make your changes
4. Add tests for new functionality
5. Ensure all tests pass: `dotnet test`
6. Commit with clear messages: `git commit -m 'Add amazing feature'`
7. Push to your branch: `git push origin feature/amazing-feature`
8. Open a Pull Request

## 📋 Development Guidelines

### Code Style
- Follow C# coding conventions
- Use meaningful variable and method names
- Add XML documentation for public APIs
- Keep methods focused and concise
- Use async/await for I/O operations

### Testing
- Write unit tests for new features
- Maintain test coverage above 80%
- Use descriptive test names
- Test both success and failure scenarios

### Documentation
- Update README.md for new features
- Add API documentation comments
- Include usage examples
- Update this file if needed

## 🏗️ Project Structure

```
TodoApp/
├── TodoApp.API/          # Web API controllers and configuration
├── TodoApp.Core/         # Domain models and business logic
├── TodoApp.Infrastructure/ # Data access and external services
└── TodoApp.Tests/        # Unit and integration tests
```

## 🚀 Getting Started

1. Clone your fork: `git clone https://github.com/YOUR_USERNAME/todo-api-dotnet.git`
2. Add upstream: `git remote add upstream https://github.com/ORIGINAL_USERNAME/todo-api-dotnet.git`
3. Install dependencies: `dotnet restore`
4. Set up database: `docker-compose up -d postgres redis`
5. Run migrations: `dotnet ef database update --project TodoApp.Infrastructure --startup-project TodoApp.API`
6. Start development: `dotnet run --project TodoApp.API`

## 📝 Pull Request Guidelines

### Before Submitting
- [ ] Code follows project style guidelines
- [ ] Tests are added and passing
- [ ] Documentation is updated
- [ ] No breaking changes (or clearly documented)
- [ ] Commit messages are clear and descriptive

### PR Description
- Describe the changes made
- Link related issues
- Include screenshots for UI changes
- Mention any breaking changes

## 🐛 Bug Reports

When reporting bugs, please include:
- **Environment**: OS, .NET version, database version
- **Steps to reproduce**: Clear, numbered steps
- **Expected behavior**: What should happen
- **Actual behavior**: What actually happens
- **Error messages**: Full error text and stack traces
- **Additional context**: Any relevant information

## 💡 Feature Requests

When suggesting features:
- **Problem**: What problem does this solve?
- **Solution**: How should it work?
- **Benefits**: Why is this feature valuable?
- **Implementation**: Any technical considerations?

## 📞 Questions?

- **Issues**: [GitHub Issues](https://github.com/YOUR_USERNAME/todo-api-dotnet/issues)
- **Discussions**: [GitHub Discussions](https://github.com/YOUR_USERNAME/todo-api-dotnet/discussions)

Thank you for contributing! 🎉
