# 🧮 Primes (Python)

A clean and modular Python application that sums prime numbers from a given list.

> Built with **Clean Architecture**, **TDD**, and modern tools like `pytest`, `black`, `mypy`, and `ruff`.

---

## 📁 Folder Structure

```

primes/
├── app/
│   ├── application/        # Use cases (SumPrimesUseCase)
│   ├── domain/             # Core business logic (is\_prime, sum\_primes)
│   ├── exceptions/         # Custom error types (optional)
│   └── infrastructure/
│       └── cli/            # CLI adapter for user interaction
├── tests/                  # Unit and integration tests
├── main.py                 # CLI entry point
├── pyproject.toml          # Tool configuration and CLI entry
├── requirements-dev.txt    # Development dependencies
└── README.md               # This file

```

---

## 🚀 Run the App

```bash
python main.py
```

Example:

```text
Enter numbers separated by spaces:
1 2 3 4 5
Sum of primes: 10
```

---

## 🧪 Run Unit Tests

```bash
pytest
```

Optional (with coverage):

```bash
pytest --cov=app --cov-report=term-missing
```

---

## 🧠 Features

- Sum only valid prime numbers from a given list
- Ignores non-primes, negative numbers, and duplicates
- Validates input type (raises `TypeError` on invalid input)
- Full test coverage for domain, use case, and CLI
- Follows Clean Architecture: Domain → Application → Interface
- TDD from day one using `pytest`

---

## 🧪 Test Cases Covered

- ✅ `[1, 2, 3, 4, 5]` → `10`
- ✅ `[2, 2, 2, 2]` → `8`
- ✅ `[10, 11, 12, 13]` → `24`
- ❌ `["a", "b", "c"]` → raises `TypeError`
- ✅ `[]` → `0`
- ❌ `None` → raises `TypeError`
- ✅ `[101, 103, 107]` → `311`

---

## 🧼 Dev Tools & Commands

### Install dev dependencies (with [uv](https://github.com/astral-sh/uv)):

```bash
uv pip install -r requirements-dev.txt
```

### Format code:

```bash
black .
```

### Lint code:

```bash
ruff .
```

### Type check:

```bash
mypy app
```

---

## 🧪 Example: Use in Code

```python
from app.application.sum_primes_usecase import SumPrimesUseCase

use_case = SumPrimesUseCase()
result = use_case.execute([1, 2, 3, 4, 5])
print(result)  # 10
```

---

## 🧑‍💻 Author

Assessment project — maintained by `bhalut`

---

## 📄 License

MIT
