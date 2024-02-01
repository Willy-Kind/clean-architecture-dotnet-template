# Clean Architecture DotNet Template

## Description

Ths is a .NET template that provides a simple Clean Architecture implementation for building Web APIs. This template is a refactor of the standard dotnet "webapi" template, introducing a structure aiming to follow the principles of Clean Architecture.

## Getting Started

### Prerequisites

Ensure you have the following prerequisites installed:

- .NET SDK (version 8)

If you don't have the .Net SDK installed wisit [Download.Net](https://dotnet.microsoft.com/en-us/download) and follow the instruction



### Cloning from Git
To clone the repository and get started with development, run the following commands:

```bash
git clone https://github.com/YourUsername/CleanWebApiTemplate.git
cd CleanWebApiTemplate
```

### Installation

Install the template using the following command:

```bash
dotnet new -i CleanWebApiTemplate
```

### Usage
Create a new Clean Architecture Web API project with:
```bash
dotnet new CleanWebApiTemplate -n MyCleanApiProject
```

Followed by:
```bash
cd MyCleanApiProject
dotnet build
dotnet run
```

### Test
The solution contains unit and functional tests.
To run the tests:
```bash
dotnet test
```
