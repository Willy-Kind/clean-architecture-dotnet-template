# Clean Architecture DotNet Template

## Description

This is a simple .NET Web Api template with a Clean Architectureish implementation.

## Getting Started

### Prerequisites

Ensure you have the following prerequisites installed:

- .NET SDK (version 8)

If you don't have the .Net SDK installed visit [Download.Net](https://dotnet.microsoft.com/en-us/download) and follow the instruction



### Cloning from Git
To clone the repository and get started with development, run the following commands:

```bash
git clone https://github.com/Willy-Kind/clean-architecture-dotnet-template.git
```

### Installation

Install the template using the following command:

```bash
dotnet new -i clean-architecture-dotnet-template
```

### Usage
Create a new Clean Architecture Web API project with:
```bash
dotnet new ca-sln -n MyCleanApiProject
```

Followed by to build and run:
```bash
cd MyCleanApiProject
dotnet build
dotnet run --project src/*.WebApi/*.csproj
```

### Test
The solution contains unit and functional tests.
To run the tests:
```bash
dotnet test
```
