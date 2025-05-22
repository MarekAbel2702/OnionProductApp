A backend project built using Onion Architecture in ASP.NET Core 8 and C#.
The application exposes a REST API for product management with full CRUD support and MS SQL Server integration via Entity Framework Core.

Technologies and architectural patterns implemented:

• Onion Architecture – clear separation of concerns across layers (Domain, Application, Infrastructure, API)
• Repository Pattern + Service Layer
• DTO (Data Transfer Objects) for communication between layers
• FluentValidation – clean and centralized input validation
• Swagger – automatic API documentation and testing interface
• SQL Server + EF Core – persistent relational database
• Dependency Injection – aligned with SOLID principles

The project is designed to be scalable and extendable (e.g. with JWT authentication, CQRS, or a frontend built with Blazor or React).
It provides a solid foundation for real-world business applications following .NET best practices.

Projekt backendowy oparty o architekturę Onion, stworzony w ASP.NET Core 8 i C#. Aplikacja udostępnia REST API do zarządzania produktami, z pełną obsługą CRUD i integracją z bazą danych MS SQL Server za pomocą Entity Framework Core.

Zaimplementowane technologie i wzorce:
• Onion Architecture – wyraźne oddzielenie warstw (Domain, Application, Infrastructure, API)
• Repository Pattern + Service Layer
• DTO (Data Transfer Objects) do komunikacji między warstwami
• FluentValidation – walidacja danych wejściowych
• Swagger – dokumentacja i testowanie endpointów
• SQL Server + EF Core – trwała baza danych
• Dependency Injection – zgodnie z zasadami SOLID

Projekt przygotowany do dalszej rozbudowy (np. o JWT, CQRS, front w Blazor lub React). Całość stanowi solidną bazę aplikacji biznesowej z architekturą skalowalną i zgodną z najlepszymi praktykami .NET.
