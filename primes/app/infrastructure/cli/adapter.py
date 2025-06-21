from app.application.sume_primes_usecase import SumPrimesUseCase


def parse_input(input_str: str) -> list[int]:
    """
    Parse a space-separated string into a list of integers.

    Args:
        input_str (str): User-provided input.

    Returns:
        list[int]: List of integers extracted from the input.

    Raises:
        ValueError: If any value is not a valid integer.
    """
    try:
        return list(map(int, input_str.strip().split()))
    except ValueError as err:
        raise ValueError(
            "Please enter only space-separated integers."
        ) from err


def main() -> None:
    """
    Main CLI entry point for summing prime numbers.

    Prompts the user for a space-separated list of integers,
    computes the sum of prime numbers, and prints the result.
    """
    use_case = SumPrimesUseCase()

    try:
        raw = input("Enter numbers separated by spaces: ")
        numbers = parse_input(raw)
        result = use_case.execute(numbers)
        print(f"Sum of primes: {result}")
    except (ValueError, TypeError) as e:
        print(f"Error: {e}")


if __name__ == "__main__":
    main()
