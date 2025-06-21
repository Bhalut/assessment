# 🧪 Palindrome (C#)

A modular and testable C# console app that verifies whether a given string is a palindrome.

> Ignores spaces, casing, and punctuation. Built using **.NET 8**, **TDD**, and **clean architecture** principles.

## 📁 Folder Structure

```

palindrome/
├── PalindromeApp/         # Console app entry point (Program.cs) and core logic
│   ├── Application/       # Use case layer (CheckPalindromeUseCase)
│   ├── Domain/            # Domain layer (IPalindromeChecker, PalindromeChecker)
│   ├── PalindromeApp.csproj
│   └── Program.cs
├── PalindromeTests/       # xUnit test project
│   ├── PalindromeCheckerTests.cs
│   ├── CheckPalindromeUseCaseTest.cs
│   └── PalindromeTests.csproj
├── palindrome.sln         # Solution file
└── README.md              # This file

```

## 🚀 Run the App

```bash
dotnet run --project PalindromeApp
```

Example:

```text
Enter a string to check if it's a palindrome:
No lemon, no melon
Is Palindrome? Yes
```

## 🧪 Run Unit Tests

```bash
dotnet test
```

Sample output:

```
Passed!  - Failed: 0, Passed: 17, Skipped: 0, Total: 17
```

## 🧠 Features

- Ignores whitespace, punctuation, and casing
- Supports alphanumeric palindromes
- Strict validation (rejects null, empty, or meaningless inputs)
- TDD-driven with xUnit
- Clear separation of concerns via `Domain` / `Application` layers

## 📌 Test Cases Covered

- ✅ `"A man, a plan, a canal, Panama"`
- ✅ `"racecar"`
- ❌ `"Hello, World!"`
- ✅ `"12321"`
- ❌ `"12345"`
- ❌ `""`, `" "`, `"..."`, `"!!!"`
- ❌ `null` (throws `ArgumentNullException`)

### 📊 Test Coverage

- Domain and Application logic: 90–100% line coverage
- Entry point (`Program.cs`) is excluded from testing
- Full report can be generated using `coverlet` and `reportgenerator`

To generate the coverage report:

```bash
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:"PalindromeTests/TestResults/**/coverage.cobertura.xml" -targetdir:"coverage-report" -reporttypes:Html
xdg-open coverage-report/index.html
```

## 📦 Requirements

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## 🧑‍💻 Author

Assessment project — maintained by `bhalut`

## 📄 License

MIT
