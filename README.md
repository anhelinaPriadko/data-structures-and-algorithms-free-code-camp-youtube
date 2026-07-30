# Data Structures & Algorithms — freeCodeCamp (C#)

This repository contains my implementations, code examples, and practice exercises following the **Data Structures and Algorithms** course by freeCodeCamp on YouTube. 

The project is structured as a modular .NET Solution (`.sln`), where each core algorithmic topic lives in its own lightweight console project inside the `src/` directory.

---

## 🛠️ Tech Stack & Prerequisites

* **Language:** C# (.NET 8.0 / .NET 10.0 or later)
* **IDE / Editor:** Visual Studio Code (with [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension) or Visual Studio 2026
* **CLI:** [.NET SDK](https://dotnet.microsoft.com/download)

---

## 🚀 Getting Started (After Cloning)

If you have just cloned this repository to your local machine, follow these steps to get up and running:

1. **Restore project dependencies:**

```bash
    dotnet restore
``` 
2. **Build the entire solution:** 

```bash
    dotnet build
``` 

3. **Run a specific topic project:** 
Since this solution contains multiple projects under src/, specify which project to run using the --project flag:

```bash
    # Example: Run the project
    dotnet run --project src/ProjectName

    # Example: Run in Watch Mode (auto-reloads on file changes)
    dotnet watch run --project src/ProjectName
``` 


## 📁 Repository Structure
``` plaintext
.
├── DataStructuresAndAlgorithms.slnx  # Main Solution File
├── src/
│   ├── ProjectName/            # Topic folder
│       ├── ProjectName.csproj
│       └── Program.cs               # Topic entry point & tests
├── .gitignore                       # Ignores /bin, /obj, and .vs folders
└── README.md
```
## ➕ Adding a New Project to the Solution
When moving on to a new course module (e.g., Trees and Graphs), follow these steps in the terminal to create and link a new project:

#### Create a new console app inside the src/ directory:

``` bash
dotnet new console -o src/ProjectName
```

#### Add the new project to the main solution file:

``` bash
dotnet sln add src/ProjectName/ProjectName.csproj
```

#### Verify it was added correctly:

``` bash
dotnet sln list
```

#### Run your new project:

``` bash
dotnet run --project src/ProjectName
```