# Employee Management REST API (.NET)

A practice-focused **ASP.NET Core Web API** project built to implement a complete **Employee Management system** using **Entity Framework Core**, **DTO-based architecture**, and a **service-layer design** following modern .NET best practices.

This project is intended for learning, hands-on practice, and interview preparation.

---

## 🚀 Features

- ASP.NET Core Web API
- RESTful CRUD operations for Employee entity
- Entity Framework Core (Code-First approach)
- SQL Server integration
- DTOs for request and response handling
- Service layer abstraction with Dependency Injection
- Asynchronous database operations using `async/await`
- Clean and maintainable project structure
- OpenAPI documentation using Swagger / Scalar

---

## 🏗️ Project Structure

DotNet_Api_Practise_03
│
├── Controllers
│ └── EmployeeController.cs
│
├── Services
│ ├── IEmployeeService.cs
│ └── EmployeeServices.cs
│
├── Data
│ └── EmployeeDbContext.cs
│
├── Entities
│ ├── Models
│ │ └── Employee.cs
│ └── Dtos
│ ├── CreateEmployeeDto.cs
│ ├── UpdateEmployeeDto.cs
│ ├── GetEmployeeByIdDto.cs
│ └── GetAllEmployeesDto.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── README.md


---

## 📌 API Endpoints

### 🔹 Get All Employees
GET /api/Employee/All


### 🔹 Get Employee by ID
GET /api/Employee/{id}


### 🔹 Create Employee
POST /api/Employee


**Request Body**
```json
{
  "name": "John Doe",
  "email": "john.doe@example.com",
  "phone": "9876543210",
  "description": "Senior Backend Developer"
}
🔹 Update Employee
PUT /api/Employee/{id}
🔹 Delete Employee
DELETE /api/Employee/{id}
🗄️ Database
SQL Server

Entity Framework Core

Code-First with Migrations

Migration Commands
Add-Migration InitialCreate
Update-Database
🧠 Concepts Implemented
RESTful API design principles

DTO pattern for secure data transfer

Dependency Injection

Async / Await programming

LINQ queries

EF Core migrations

Clean separation of concerns

📖 API Documentation
Interactive API documentation is available using Scalar / Swagger:

https://localhost:{port}/scalar
🛠️ Tech Stack
ASP.NET Core Web API

Entity Framework Core

SQL Server

C#

LINQ

Scalar / Swagger (OpenAPI)

👤 Author
Tapan Ray
.NET Backend Developer
