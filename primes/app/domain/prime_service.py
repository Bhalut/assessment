from app.exceptions.app_errors import InvalidInputError


def is_prime(n: int) -> bool:
    """
    Check if a number is prime.
    A prime number is a natural number greater than 1
    that cannot be formed by multiplying two
    smaller natural numbers. The only even prime number is 2.
    Args:
        n (int): The number to check.
    Returns:
        bool: True if n is prime, False otherwise.
    Examples:
        >>> is_prime(2)
        True
        >>> is_prime(3)
        True
        >>> is_prime(4)
        False
        >>> is_prime(5)
        True
        >>> is_prime(1)
        False
        >>> is_prime(0)
        False
    """
    if n < 2:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True


def sum_primes(numbers: list[int]) -> int:
    """
    Calculate the sum of all prime numbers in a list.

    Args:
        numbers (list[int]): A list of integers.

    Returns:
        int: The sum of all prime numbers in the list.

    Raises:
        TypeError: If input is not a list of integers.

    Examples:
        >>> sum_primes([1, 2, 3, 4, 5])
        10
    """
    if not isinstance(numbers, list) or not all(isinstance(n, int) for n in numbers):
        raise InvalidInputError("Expected a list of integers")

    return sum(filter(is_prime, numbers))
