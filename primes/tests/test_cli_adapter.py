"""
Integration tests for the CLI adapter.

These tests simulate user input via the command line
and verify correct output behavior, including error handling.
"""

from app.infrastructure.cli import adapter


def test_cli_adapter_valid_input(monkeypatch, capsys):
    """
    Test the CLI with valid numeric input.
    """
    monkeypatch.setattr("builtins.input", lambda _: "2 3 4 5")
    adapter.main()
    captured = capsys.readouterr()
    assert "Sum of primes: 10" in captured.out


def test_cli_adapter_invalid_input(monkeypatch, capsys):
    """
    Test the CLI with non-numeric input.
    """
    monkeypatch.setattr("builtins.input", lambda _: "two three")
    adapter.main()
    captured = capsys.readouterr()
    assert "Error" in captured.out
