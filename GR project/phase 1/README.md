# WaslRepo - Phase 1

This repository contains the first phase of the Wasl backend data layer, built with .NET and Entity Framework Core using SQL Server.

## Overview

The project currently focuses on:

- Defining the core domain models
- Configuring entity mappings with Fluent API
- Managing database schema changes through EF Core migrations
- Providing a central `AppDbContext` for database access

## Tech Stack

- .NET 10
- C#
- Entity Framework Core 10
- SQL Server

## Project Structure

```text
phase 1/
|-- Configurations/   # EntityTypeConfiguration classes
|-- Data/             # DbContext
|-- Migrations/       # EF Core migrations
|-- Models/           # Domain models
|-- Program.cs
|-- phase 1.csproj
```

## Main Entities

The data model includes the following main entities:

- `User`
- `OtpCode`
- `PatientProfile`
- `StudentProfile`
- `LocationArea`
- `ServiceType`
- `TreatmentCategory`
- `Case`
- `Offer`
- `Match`
- `Conversation`
- `Message`
- `Session`
- `Reminder`
- `Review`
- `NoShowStrike`
- `Report`

## Database Context

The main database context is located at:

- `phase 1/Data/AppDbContext.cs`

It applies all entity configurations automatically from the assembly using:

```csharp
modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
```

## Getting Started

1. Install the .NET SDK that supports `net10.0`.
2. Make sure SQL Server is available locally.
3. Update the connection string in `AppDbContext` if needed.
4. Restore dependencies:

```bash
dotnet restore
```

5. Apply migrations:

```bash
dotnet ef database update --project "phase 1/phase 1.csproj"
```

## Notes

- The current connection string is hardcoded in `AppDbContext`.
- `Program.cs` is currently minimal, which suggests this phase is focused on the database layer and schema setup.

## Author

Prepared as part of the Wasl project - Phase 1.
