# OnionProductApp – REST API w ASP.NET Core 8 (.NET 8)

Aplikacja REST API do zarządzania produktami, zbudowana z użyciem Onion Architecture w ASP.NET Core 8 oraz Entity Framework Core. Projekt został stworzony jako część samodzielnej nauki i budowy portfolio .NET Developera.

---

## 🛠️ Technologie

- ASP.NET Core 8
- C#
- Entity Framework Core 9
- SQL Server
- FluentValidation
- Swagger / OpenAPI
- Onion Architecture
- REST API
- SOLID + Dependency Injection

---

## ✨ Funkcjonalności

- 🔁 CRUD na produktach (Create, Read, Update, Delete)
- ✅ Walidacja danych wejściowych z FluentValidation
- 📂 Podział na warstwy: Domain, Application, Infrastructure, API
- 📡 Dokumentacja i testowanie API przez Swagger UI
- 💾 Trwała baza danych MS SQL Server (przez EF Core)

---

## 📁 Struktura projektu
OnionProductAPI
├── OnionProductAPI.Domain # Encje domenowe, interfejsy repozytoriów
├── OnionProductAPI.Application # DTO, interfejsy i serwisy biznesowe
├── OnionProductAPI.Infrastructure # EF Core DbContext, implementacje repo
└── OnionProductAPI.API # Kontrolery, Program.cs, konfiguracja

## 🚀 Jak uruchomić

1. Skonfiguruj connection string do SQL Servera w `appsettings.json`
2. Wykonaj migrację bazy:
dotnet ef database update --startup-project ../OnionProductAPI.API
3. Uruchom projekt API
4. Wejdź na `https://localhost:{port}/swagger` i testuj endpointy!

---

## 🌍 English Summary

**OnionProductApp** is a RESTful API for managing products, built with Onion Architecture in ASP.NET Core 8 and Entity Framework Core.

### ✅ Features:
- Full CRUD operations
- Clean separation of layers (Domain, Application, Infrastructure, API)
- Repository Pattern & Service Layer
- FluentValidation integration
- Swagger for API documentation and testing
- SQL Server + EF Core database

---

📚 _This project was completed as part of my self-directed learning and portfolio development as a .NET Developer._

---

## 🔗 Linki

- ✅ GitHub repo: https://github.com/MarekAbel2702/OnionProductApp
- 👤 LinkedIn: [(https://www.linkedin.com/in/marek-abel-655723348/)]

---

