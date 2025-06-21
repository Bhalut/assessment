from app.domain.prime_service import sum_primes


class SumPrimesUseCase:
    """
    Use case to calculate the sum of prime numbers in a list.

    This class encapsulates the application logic for summing prime numbers
    from a given list of integers. It delegates the logic to the domain layer.

    Methods:
        execute(numbers: list[int]) -> int:
            Returns the sum of all prime numbers in the input list.
    """

    def execute(self, numbers: list[int]) -> int:
        """
        Execute the use case.

        Args:
            numbers (list[int]): A list of integers to evaluate.

        Returns:
            int: The sum of all prime numbers in the list.

        Raises:
            TypeError: If the input is not a list of integers.

        Examples:
            >>> use_case = SumPrimesUseCase()
            >>> use_case.execute([1, 2, 3, 4, 5])
            10
            >>> use_case.execute([10, 11, 12, 13])
            24
        """
        return sum_primes(numbers)
