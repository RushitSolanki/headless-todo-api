# Security Policy

## Supported Versions

| Version | Supported          |
| ------- | ------------------ |
| 1.0.x   | :white_check_mark: |

## Reporting a Vulnerability

We take security seriously. If you discover a security vulnerability, please follow these steps:

### 1. **DO NOT** create a public GitHub issue
Security vulnerabilities should be reported privately to prevent exploitation.

### 2. Email Security Report
Send an email to [your-email@example.com] with:
- **Subject**: `[SECURITY] Vulnerability Report - TODO API`
- **Description**: Detailed description of the vulnerability
- **Steps to reproduce**: Clear reproduction steps
- **Impact**: Potential impact assessment
- **Suggested fix**: If you have ideas for fixing it

### 3. Response Timeline
- **Initial Response**: Within 48 hours
- **Status Update**: Within 7 days
- **Resolution**: Depends on complexity and severity

### 4. Public Disclosure
- Vulnerabilities will be disclosed publicly after fixes are released
- Credit will be given to reporters (unless requested otherwise)
- CVE numbers will be requested for significant issues

## Security Best Practices

### For Contributors
- Never commit secrets or sensitive data
- Use environment variables for configuration
- Follow secure coding practices
- Review code for security issues
- Keep dependencies updated

### For Users
- Keep the application updated
- Use strong passwords
- Enable HTTPS in production
- Regularly backup data
- Monitor logs for suspicious activity

## Security Features

### Implemented
- ✅ Input validation
- ✅ SQL injection prevention (EF Core)
- ✅ CORS configuration
- ✅ Secure headers
- ✅ Environment-based configuration

### Planned
- 🔄 JWT authentication
- 🔄 Rate limiting
- 🔄 Request logging
- 🔄 Security monitoring
- 🔄 Penetration testing

## Dependencies

We regularly update dependencies to patch security vulnerabilities:

```bash
# Check for outdated packages
dotnet list package --outdated

# Update packages
dotnet add package [package-name] --version [latest-version]
```

## Security Checklist

Before deploying to production:
- [ ] All dependencies updated
- [ ] HTTPS enabled
- [ ] Environment variables configured
- [ ] Database credentials secured
- [ ] Logging configured
- [ ] Monitoring enabled
- [ ] Backup strategy in place

Thank you for helping keep this project secure! 🔒
