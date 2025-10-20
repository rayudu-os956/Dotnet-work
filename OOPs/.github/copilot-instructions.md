## Quick orientation

This repository is a small .NET solution with two projects:

- `OOPs/` — console app (executable). See `OOPs/Program.cs`.
- `ClassLibrary1/` — class library. See `ClassLibrary1/Class1.cs` (defines `Customer`).
- Solution file: `OOPs.sln`.

Target framework: `net9.0`. Nullable references are enabled and implicit usings are turned on in both projects.

## What to change and why

- Prefer small, focused edits. This is an educational/example codebase; most changes should be additive (new classes, small refactors) rather than sweeping architectural rewrites.
- When adding cross-project usage, wire a ProjectReference in the consumer project's `.csproj` (the console already references `..\ClassLibrary1\ClassLibrary1.csproj`).

## Build / run / debug commands

- Restore (if needed):

  dotnet restore

- Build solution:

  dotnet build OOPs.sln

- Run the console app from the repo root:

  dotnet run --project OOPs/OOPs.csproj

- Run tests: there are no test projects currently. If you add tests, run:

  dotnet test

In VS Code use the .NET (C#) extension to debug `OOPs` — set the launch project to `OOPs/OOPs.csproj`.

## Project-specific patterns and conventions

- Minimal project layout: each project uses SDK-style csproj with `ImplicitUsings` enabled. Don't add redundant global usings unless necessary.
- Nullable reference types are enabled (`<Nullable>enable</Nullable>`). Add nullability annotations and prefer non-nullable types by default.
- Namespaces follow the folder/project names: `ClassLibrary1` contains `Customer` in the `ClassLibrary1` namespace. Keep new types in the project namespace.

## Common edits examples (copy-ready)

- Add a new POCO to the library:

  File: `ClassLibrary1/Order.cs`
  namespace `ClassLibrary1` — public class `Order { public int Id { get; set; } }`

- Use the library from the app (already demonstrated in `OOPs/Program.cs` / `Sample`): import `ClassLibrary1` and reference types like `Customer`.

## Integration & external dependencies

- There are no NuGet packages referenced in these csproj files. If adding packages, modify the appropriate project's `.csproj` and run `dotnet restore`.

## Editing guidance for AI agents

- Keep changes minimal and build locally after edits. Required verification steps: `dotnet build` -> `dotnet run` (if editing runtime behavior).
- Preserve existing project-level settings: `ImplicitUsings` and `Nullable` should remain enabled unless there is a strong reason.
- Follow existing naming and folder conventions: new types go into their project folder and namespace.

## Files to inspect when making changes

- `OOPs/Program.cs` — app entry and example usage
- `ClassLibrary1/Class1.cs` — library types
- `OOPs/OOPs.csproj` and `ClassLibrary1/ClassLibrary1.csproj` — project wiring
- `OOPs.sln` — solution that groups both projects

If anything here is unclear or you'd like the file expanded with more examples (tests, contribution rules, or CI commands), tell me where you'd like more detail and I will iterate.
