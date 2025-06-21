namespace PalindromeApp.Application;

using PalindromeApp.Domain;

/// <summary>
/// Use case for checking whether an input is a palindrome, as part of application business logic.
/// </summary>
public class CheckPalindromeUseCase
{
    private readonly IPalindromeChecker _palindromeChecker;

    /// <summary>
    /// Initializes a new instance of the <see cref="CheckPalindromeUseCase"/> class.
    /// </summary>
    /// <param name="palindromeChecker">An implementation of <see cref="IPalindromeChecker"/>.</param>
    public CheckPalindromeUseCase(IPalindromeChecker palindromeChecker)
    {
        _palindromeChecker = palindromeChecker ?? throw new ArgumentNullException(nameof(palindromeChecker));
    }

    /// <summary>
    /// Executes the use case logic to determine if the input string is a palindrome.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns><c>true</c> if the input is a palindrome; otherwise, <c>false</c>.</returns>
    public bool Execute(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input));

        if (input.Length == 0)
            throw new ArgumentException("Input cannot be an empty string.", nameof(input));

        return _palindromeChecker.IsPalindrome(input);
    }
}
