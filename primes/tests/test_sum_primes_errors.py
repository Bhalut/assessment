"""
Negative tests for the `sum_primes` function.

These tests ensure that the function raises TypeError when given
invalid inputs such as None, non-integer values, or incorrect types.
"""

import pytest

from app.domain.prime_service import sum_primes
from app.exceptions.app_errors import InvalidInputError


def test_sum_primes_with_none():
    """
    Test that passing None raises a InvalidInputError.
    """
    with pytest.raises(InvalidInputError):
        sum_primes(None)


@pytest.mark.parametrize(
    "invalid_input",
    [
        "123",
        42,
        [2, "three", 5],
        {"a": 1},
        (2, 3, 5),
    ],
)
def test_sum_primes_with_invalid_types(invalid_input):
    """
    Test that passing invalid types to sum_primes raises a InvalidInputError.

    Args:
        invalid_input: A value that is not a valid list of integers.

    Raises:
        AssertionError: If InvalidInputError is not raised.
    """
    with pytest.raises(InvalidInputError):
        sum_primes(invalid_input)
