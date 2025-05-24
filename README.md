# 🚀 AlgoPrep: Mastering Data Structures & Algorithms in C#

Welcome to **AlgoPrep**, a curated C# repository focused on mastering data structures and algorithms through consistent problem-solving using LeetCode.

> ✨ Built for devs who want **clarity, structure, and C#-specific practice** for technical interviews or foundational mastery.

---

## 📚 Repository Highlights

- 📦 **Modular Problem Structure**: Each problem lives in its own self-contained project
- 🧠 **Pattern-Based Learning**: Linked to algorithm patterns & LeetCode75 roadmap
- ⚙️ **C# Focused**: Clean, idiomatic `.NET` code with comments and optional complexity analysis
- ✅ **Progress-Oriented**: Easy to track and extend with your own study path

---

## 🧱 Folder Structure

```bash
algoprep/
├── docs/                 # LeetCode 75 Study Plan problems
├── leetcode75/                 # LeetCode 75 Study Plan problems
├── Problems/                   # Individual problems
│   ├── 001_TwoSum/
│   │   └── 001_TwoSum.csproj
│   ├── 002_AddTwoNumbers/
│   │   └── 002_AddTwoNumbers.csproj
│   └── ...
├── CSharp_Algorithm_Patterns.md # Pattern explanations (e.g. Two Pointers, Sliding Window)
├── algoprep.sln                # Solution file (includes all projects)
└── README.md                   # You're here!
```

---

## 🔧 Getting Started

### 📦 Requirements

- [.NET SDK](https://dotnet.microsoft.com/download)
- IDE: Visual Studio or VS Code with C# extension

### ▶️ Run a Problem

```bash
cd Problems/001_TwoSum
dotnet run
```

### 🧪 (Optional) Add Unit Tests

You can create a `Tests/` folder using `xUnit` or `NUnit` for TDD-style learning.

---

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

---

## 📈 Study Plans

This repo includes structured learning plans:

### ✅ [LeetCode 75 Plan](./leetcode75/README.md)
- Focused sequence of ~75 curated LeetCode problems.
- Learn by topic: Arrays, Hash Maps, Linked Lists, Trees, DP, etc.
- Annotated and explained in C# context.

### 🔁 [C# Algorithm Patterns](./CSharp_Algorithm_Patterns.md)
- Strategy-focused guide across common patterns:
  - Two Pointers
  - Sliding Window
  - DFS/BFS
  - Dynamic Programming
  - Greedy
  - ...and more.

---

## 🤝 Contributing

If you'd like to improve the repo or add new problems:

1. Fork the repo
2. Add your project in `/Problems/###_ShortName/`
3. Use C# and follow naming conventions
4. Submit a pull request

---

## 🧠 Tips for Effective Learning

- Code from scratch after understanding solutions
- Comment key decisions and complexities
- Talk through your approach like a mock interview
- Track time spent and review failures intentionally

---

> “It’s not that I’m so smart, it’s just that I stay with problems longer.”  
> — *Albert Einstein*

---

## 📬 Contact

Maintained by [@gillisce](https://github.com/gillisce)  
Feel free to open issues for questions, suggestions, or new patterns!

---

Happy coding! 💻
