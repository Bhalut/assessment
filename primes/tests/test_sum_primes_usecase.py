"""
Unit tests for the SumPrimesUseCase.

These tests verify that the application layer correctly
delegates to the domain logic and returns expected results.
"""

from app.application.sume_primes_usecase import SumPrimesUseCase


def test_usecase_sum_primes_basic():
    """
    Test that the use case returns the correct sum for a basic input list.
    """
    use_case = SumPrimesUseCase()
    result = use_case.execute([1, 2, 3, 4, 5])
    assert result == 10


def test_usecase_with_empty_list():
    """
    Test that the use case returns 0 when given an empty list.
    """
    use_case = SumPrimesUseCase()
    result = use_case.execute([])
    assert result == 0
