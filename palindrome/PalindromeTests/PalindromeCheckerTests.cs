using PalindromeApp.Domain;

namespace PalindromeTests;

/// <summary>
/// Unit tests for the <see cref="PalindromeChecker"/> class.
/// </summary>
public class PalindromeCheckerTests
{
    private readonly IPalindromeChecker _checker = new PalindromeChecker();

    /// <summary>
    /// Tests whether various inputs are correctly identified as palindromes or not.
    /// </summary>
    [Theory]
    [InlineData("A man, a plan, a canal, Panama", true)]
    [InlineData("racecar", true)]
    [InlineData("Hello, World!", false)]
    [InlineData("No lemon, no melon", true)]
    [InlineData("Was it a car or a cat I saw", true)]
    [InlineData(" ", false)] // Only whitespace
    [InlineData("", false)] // Empty string
    [InlineData("12321", true)] // Numeric palindrome
    [InlineData("12345", false)] // Numeric non-palindrome
    [InlineData("...", false)] // Only punctuation
    [InlineData("!!!", false)] // Only symbols
    [InlineData("Madam", true)] // Case-insensitive
    [InlineData("MadaM", true)] // Mixed case
    public void IsPalindrome_ShouldReturnExpectedResult(string input, bool expected)
    {
        var result = _checker.IsPalindrome(input);
        Assert.Equal(expected, result);
    }

    /// <summary>
    /// Tests whether null input throws an ArgumentNullException.
    /// </summary>
    [Fact]
    public void IsPalindrome_ShouldThrow_WhenInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _checker.IsPalindrome(null!));
    }
}
