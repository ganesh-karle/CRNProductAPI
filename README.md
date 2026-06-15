# CRN Product API

## Overview

This project is a RESTful Web API developed using ASP.NET Core 8 and SQL Server.

The API provides CRUD operations for Product Management and follows Clean Architecture principles using Repository Pattern, Service Layer, DTOs, JWT Authentication, AutoMapper and Entity Framework Core.

---

## Tech Stack

* ASP.NET Core 8 Web API
* C#
* SQL Server
* Entity Framework Core
* Repository Pattern
* Service Layer
* DTO Pattern
* AutoMapper
* JWT Authentication
* Swagger

---

## Project Structure

CRNProductAPI

├── Controllers

├── DTOs

├── Interfaces

├── Services

├── Data

├── Repositories

├── Entities

└── Program.cs

---

## Features

### Product CRUD

* Get All Products
* Get Product By Id
* Create Product
* Update Product
* Delete Product

### Authentication

* JWT Token Generation
* Protected APIs using Authorize Attribute

### Validation

* DTO Based Request Models

### Documentation

* Swagger UI

---

## Database

### Product Table

* Id
* ProductName
* CreatedBy
* CreatedOn
* ModifiedBy
* ModifiedOn

### Item Table

* Id
* ProductId
* Quantity

---

## API Endpoints

### Authentication

POST /api/Auth/login

### Product

GET /api/Products

GET /api/Products/{id}

POST /api/Products

PUT /api/Products/{id}

DELETE /api/Products/{id}

---

## Login Credentials

Username: admin

Password: 123

---

## How To Run

1. Clone Repository

2. Update Connection String

3. Run Migration

Add-Migration InitialCreate

Update-Database

4. Run Application

5. Open Swagger

https://localhost:7050/swagger

---

## Author

Ganesh Ashok Karle

TYBSc Computer Science

ASP.NET Core Developer
