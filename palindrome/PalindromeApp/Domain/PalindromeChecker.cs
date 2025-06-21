namespace PalindromeApp.Domain;

using System;
using System.Linq;

/// <summary>
/// Concrete implementation of <see cref="IPalindromeChecker"/> that determines
/// whether a given string is a palindrome.
/// </summary>
public class PalindromeChecker : IPalindromeChecker
{
    /// <summary>
    /// Determines whether the specified input string is a palindrome.
    /// A palindrome is a sequence of characters that reads the same backward as forward,
    /// ignoring casing and non-alphanumeric characters.
    /// </summary>
    /// <param name="input">The string to evaluate.</param>
    /// <returns>
    /// <c>true</c> if the input is a palindrome; otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if the input is <c>null</c>.
    /// </exception>
    public bool IsPalindrome(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input));

        var cleaned = new string(
            input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)
                .ToArray()
        );

        if (string.IsNullOrEmpty(cleaned))
            return false;

        return cleaned.SequenceEqual(cleaned.Reverse());
    }
}
