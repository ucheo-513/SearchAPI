# Parts Search API 🔍

ASP.NET Core Web API for searching parts inventory with pagination support.

![.NET Version](https://img.shields.io/badge/.NET-6.0-blue)
![API Status](https://img.shields.io/badge/status-active-brightgreen)

## Features
- Search parts by part number
- Paginated results
- Total count metadata
- Error handling
- Clean architecture (Repository → Service → Controller)

## Tech Stack
- **Backend**: ASP.NET Core 6
- **Database**: Entity Framework Core
- **API Documentation**: Swagger/OpenAPI

## API Endpoints

### POST `/api/search`
Search parts with pagination

**Request:**
```http
POST /api/search?CurrentPage=1&ItemsPerPage=10
Content-Type: multipart/form-data


