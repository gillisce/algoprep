# .NET Interview Prep Repository

This repository contains C# solutions to common coding interview problems. This README explains the workflow for adding new problem solutions to the repository.

## Project Structure

```
/InterviewPrep
├── InterviewProblems.sln
└── Problems/
    ├── ProblemOne/
    │   ├── ProblemOne.csproj
    │   └── Program.cs
    ├── ProblemTwo/
    │   ├── ProblemTwo.csproj
    │   └── Program.cs
    └── ...
```

## Important Note About .NET Project Creation

When using `dotnet new console -n ProblemName`, the command **does not automatically add the newly created project to your existing solution file** (`.sln`).

### Why This Happens

* **Explicit Control**: The .NET CLI is designed to give you explicit control. It assumes you might want to create projects independently of a solution or add them to a different solution later.

* **Location**: When you run `dotnet new console -n ProblemName`, it creates a new folder named `ProblemName` and puts the `.csproj` file inside it, along with the `Program.cs` and other project files. It doesn't automatically know where your solution file is located.

* **Solution Files as Organizers**: Solution files (`.sln`) are organizational tools that help IDEs and the `dotnet` CLI understand relationships between multiple projects. Projects can exist without being part of any solution.

## Workflow for Adding New Problems

### 1. Create a New Project for the Problem

Navigate to your repository root and run:

```bash
dotnet new console -n ProblemName -o Problems/ProblemName
```

This creates:
- A new folder `Problems/ProblemName`
- A C# project file `ProblemName.csproj` inside that folder
- A default `Program.cs` file

### 2. Add the Project to Your Solution

After creating the project, you need to explicitly add it to your solution:

```bash
dotnet sln add Problems/ProblemName/ProblemName.csproj
```

### 3. Implement Your Solution

Now you can implement your solution in the `Program.cs` file or create additional classes as needed.

### 4. Build and Test

Build your solution:

```bash
dotnet build
```

Run your specific project:

```bash
dotnet run --project Problems/ProblemName/ProblemName.csproj
```

## Complete Example Workflow

```bash
# Initial setup (only needed once)
mkdir InterviewPrep
cd InterviewPrep
dotnet new sln -n InterviewProblems

# For each new problem
dotnet new console -n TwoSumProblem -o Problems/TwoSumProblem
dotnet sln add Problems/TwoSumProblem/TwoSumProblem.csproj

# Navigate to problem directory to work on it
cd Problems/TwoSumProblem
# Edit Program.cs...

# Or run the project from the solution root
cd ../..
dotnet run --project Problems/TwoSumProblem/TwoSumProblem.csproj
```

## IDE Integration

When you open `InterviewProblems.sln` in Visual Studio or VS Code (with C# extension), you'll see all problems listed in the Solution Explorer, making it easy to navigate between different problem implementations.

Happy coding and good luck with your interview preparation!
