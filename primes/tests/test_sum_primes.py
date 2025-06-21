"""
Unit tests for the `sum_primes` function in the domain layer.

These tests cover valid inputs and expected outputs,
ensuring the function correctly sums prime numbers
in various scenarios, including edge cases.
"""

import pytest

from app.domain.prime_service import sum_primes


@pytest.mark.parametrize(
    "numbers, expected",
    [
        ([1, 2, 3, 4, 5, 6], 10),
        ([], 0),
        ([0, 1, 4, 6, 8], 0),
        ([2, 3, 5, 7], 17),
        ([10, 11, 12, 13], 24),
        ([29, 30, 31], 60),
        ([2, 2, 2, 2], 8),
        ([101, 103, 107], 311),
        ([-3, -2, -1, 0, 1, 2, 3], 5),
    ],
)
def test_sum_primes(numbers, expected):
    """
    Ensure that sum_primes returns the correct sum of prime numbers
    for valid input lists.

    Args:
        numbers (list[int]): Input list of integers.
        expected (int): Expected result.

    Raises:
        AssertionError: If the result does not match the expected value.
    """
    assert sum_primes(numbers) == expected
