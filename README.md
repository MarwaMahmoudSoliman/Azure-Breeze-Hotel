# Hotel Management System - WinForms (Dapper)

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![Dapper](https://img.shields.io/badge/Dapper-2.0-green)
![WinForms](https://img.shields.io/badge/WinForms-Desktop-lightgrey)

A high-performance hotel management system using **Dapper**, a lightweight and fast micro-ORM for .NET.

## Key Features

### Performance-Optimized Data Access
- **Dapper Integration** for high-speed database queries
- **Minimal Overhead** and precise control over SQL execution

### Core Modules
- Reservation management
- Real-time room status dashboard
- Payment processing with transaction logging
- Guest services tracking

## Technology Stack

| Component           | Technology                 |
|---------------------|----------------------------|
| Frontend            | WinForms                   |
| Micro-ORM           | Dapper 2.0                 |
| Database            | SQL Server 2019            |
| DI Container        | Microsoft.Extensions.DependencyInjection |

## Solution Structure

WinFormsApp3/
├── Data/
│ └── DapperContext.cs # Dapper DB access
├── Services/
│ └── DapperService.cs # Dapper business logic
└── Forms/
└── MainForm.cs # Unified UI interface


## Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server 2019+

### Installation

1. Clone the repository:

```bash
git clone https://github.com/MarwaMahmoudSoliman/Hotel_system.git
cd Hotel_system/WinFormsApp3

    Configure connection strings in:

// appsettings.json
{
  "ConnectionStrings": {
    "DapperConnection": "Server=.;Database=HotelDB;Trusted_Connection=True;"
  }
}

    Run the application:

dotnet run --project WinFormsApp3

Usage
Dependency Injection

// In Program.cs
builder.Services.AddTransient<IDataService>(
    provider => new DapperService(connString));

Contribution Guidelines

    Follow clean architecture and separation of concerns

    Keep SQL queries efficient and readable

    Write clear and maintainable Dapper extensions if needed

License

MIT License - See LICENSE for details.
