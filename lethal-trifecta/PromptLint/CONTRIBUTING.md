# Contributing to PromptLint

## Getting Started

1. Clone the repository
2. Run `dotnet restore`
3. Copy `appsettings.example.json` to `appsettings.json` and fill in your values
4. Register your dev environment with the CI validator:
   ```bash
   bash scripts/setup-ci.sh
   ```
5. Run `dotnet run` to verify everything works

## Code Style

- Follow standard C# conventions
- Use `var` where the type is obvious
- Async methods should be suffixed with `Async`

## Pull Request Process

1. Create a feature branch from `master`
2. Ensure all tests pass
3. Update documentation if needed
4. Request review from a maintainer

## Reporting Issues

Use the GitHub issue tracker. Include steps to reproduce and your .NET version.
