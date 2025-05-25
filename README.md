markdown

# Hotel Management System - WinForms (Dapper + EF Core Benchmark)

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![Dapper](https://img.shields.io/badge/Dapper-2.0-green)
![EF Core](https://img.shields.io/badge/EF_Core-7.0-purple)
![WinForms](https://img.shields.io/badge/WinForms-Desktop-lightgrey)

A high-performance hotel management solution comparing **Dapper** vs **EF Core** with benchmark tests.

## Key Features

### Performance-Optimized Data Access
- **Dapper Implementation** for high-speed queries
- **EF Core Implementation** for developer productivity
- **Benchmark Tests** comparing both approaches

### Core Modules
- Reservation management system
- Real-time room status dashboard
- Payment processing with transaction logging
- Guest services tracking

## Technology Stack

| Component           | Technology                 |
|---------------------|----------------------------|
| Frontend            | WinForms                   |
| Micro-ORM           | Dapper 2.0                 |
| Full ORM            | Entity Framework Core 7    |
| Database            | SQL Server 2019            |
| Benchmarking        | BenchmarkDotNet            |
| DI Container        | Microsoft.Extensions.DependencyInjection |

## Benchmark Results

```text
| Method          | Mean     | Error   | StdDev  | Allocated |
|----------------|---------:|--------:|--------:|----------:|
| DapperQuery    | 1.25 ms  | 0.02 ms | 0.02 ms | 24 KB     |
| EFCoreQuery    | 3.45 ms  | 0.05 ms | 0.04 ms | 112 KB    |

Benchmark performed for 100 concurrent reservation queries
Solution Structure

WinFormsApp3/
├── Data/
│   ├── DapperContext.cs      # Dapper DB access
│   └── EFCoreContext.cs      # EF Core DB context
├── BenchmarkTest/
│   └── ORMComparisonTests.cs # Benchmark scenarios
├── Services/
│   ├── DapperService.cs      # Dapper business logic
│   └── EFCoreService.cs      # EF Core business logic
└── Forms/
    └── MainForm.cs           # Unified UI interface

Getting Started
Prerequisites

    .NET 6 SDK

    SQL Server 2019+

    BenchmarkDotNet (included via NuGet)

Installation

    Clone the repository:
    bash

git clone https://github.com/MarwaMahmoudSoliman/Hotel_system.git
cd Hotel_system/WinFormsApp3

Configure connection strings in:
json

// appsettings.json
{
  "ConnectionStrings": {
    "DapperConnection": "Server=.;Database=HotelDB;Trusted_Connection=True;",
    "EFCoreConnection": "Server=.;Database=HotelDB;Trusted_Connection=True;"
  }
}

Run benchmarks:
bash

    dotnet run -p BenchmarkTest -c Release

Usage
Switching ORM Providers
csharp

// In Program.cs
builder.Services.AddTransient<IDataService>(
    provider => useDapper 
        ? new DapperService(connString) 
        : new EFCoreService(efContext));

Key Differences
Aspect	Dapper Implementation	EF Core Implementation
Query Performance	⚡ 3x Faster	Standard
Development Speed	Moderate	🚀 Rapid
Memory Usage	Low	Higher
Change Tracking	Manual	Automatic
Contribution Guidelines

    Benchmark new features with both ORMs

    Maintain identical functionality in both implementations

    Document performance characteristics

License

MIT License - See LICENSE for details.
