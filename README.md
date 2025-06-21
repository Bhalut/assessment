# 🧠 Assessment

Comprehensive technical assessment combining **theory**, **Python** and **C#** exercises, designed to demonstrate architecture, testing, and DevOps best practices.

## 📦 Project Structure

```

.
├── docs/             # Theoretical component (AWS, DevOps, CI/CD)
├── palindrome/       # C# Palindrome console app with Clean Architecture and tests
├── primes/           # Python prime summation with TDD and Clean Architecture
├── .gitignore
└── README.md         # This file

```

## ✅ Project Components

### 🔢 `primes/` - Python Prime Number Summation

- Sums all prime numbers in a given list of integers.
- Uses **Clean Architecture**, **TDD**, and tools like `pytest`, `black`, `mypy`, `ruff`.
- Fully tested, typed, and documented.

**Run CLI:**

```bash
cd primes
python main.py
```

**Run tests:**

```bash
pytest
```

**More info:** [primes/README.md](./primes/README.md)

### 🔁 `palindrome/` - C# Palindrome Checker

- Verifies if a string is a palindrome (ignores casing, spaces, punctuation).
- Built with **.NET 8**, **xUnit**, and Clean Architecture principles.
- Includes coverage report.

**Run the app:**

```bash
cd palindrome/PalindromeApp
dotnet run
```

**Run tests:**

```bash
cd palindrome/PalindromeTests
dotnet test
```

**More info:** [palindrome/README.md](./palindrome/README.md)

### 📘 `docs/` - Theoretical Questions

Includes answers to key cloud and DevOps topics:

- Amazon RDS vs DynamoDB
- AWS Lambda and serverless
- DevOps principles with AWS Code tools
- CI/CD with CodePipeline and CodeBuild
- Amazon S3 usage with code examples

**View here:** [docs/theory.md](./docs/theory.md)

## 🔧 Tools Used

| Purpose        | Tool                                          |
| -------------- | --------------------------------------------- |
| Python Testing | `pytest`                                      |
| Linting        | `ruff`                                        |
| Formatting     | `black`                                       |
| Typing         | `mypy`                                        |
| Virtual Env    | `uv`                                          |
| C# Testing     | `xUnit`                                       |
| AWS Concepts   | Lambda, S3, RDS, DynamoDB, CodePipeline, etc. |

## 👨‍💻 Author

Created and maintained by `bhalut` for technical assessment purposes.

## 📄 License

MIT
