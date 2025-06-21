namespace PalindromeApp.Domain;

/// <summary>
/// Contract for checking whether a string is a palindrome.
/// </summary>
public interface IPalindromeChecker
{
    /// <summary>
    /// Determines whether the specified input is a palindrome.
    /// </summary>
    /// <param name="input">The input string to check.</param>
    /// <returns><c>true</c> if the input is a palindrome; otherwise, <c>false</c>.</returns>
    bool IsPalindrome(string input);
}
