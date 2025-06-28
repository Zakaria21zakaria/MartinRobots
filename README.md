# 🤖 Martian Robots Console App (C# .NET 9)

This is a C# .NET 9 console application that simulates robot navigation on a rectangular Mars grid, based on the classic **Martian Robots** problem.

---

## 🚀 Problem Summary

- Robots are placed on a bounded grid and receive movement instructions:
  - `L`: Turn left
  - `R`: Turn right
  - `F`: Move forward
- If a robot moves off the grid, it is considered **LOST**.
- A scent is left at the point where a robot was lost to prevent other robots from being lost in the same way.

---

## ⚙️ Requirements

- [.NET 9 SDK (Preview)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Terminal or console access

---

## 🛠️ Build and Run

### 1. Navigate to the project directory and run (.../MartinRobots/MartinRobots):

```bash
# Restore dependencies
dotnet restore

# Build the application
dotnet build

# Run the console app
dotnet run
```
![image](https://github.com/user-attachments/assets/e353e0aa-bb8e-431c-ac6f-973398115472)




## 2. Running tests
### Navigate to the test project (../MartinRobots/MartinRobots.tests)
```bash
dotnet test
```
