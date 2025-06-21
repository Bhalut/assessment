class AppError(Exception):
    """Base class for application-level exceptions."""

    pass


class InvalidInputError(AppError):
    """Raised when input data is invalid."""

    pass
