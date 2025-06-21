using PalindromeApp.Application;
using PalindromeApp.Domain;

namespace PalindromeTests;

/// <summary>
/// Unit tests for <see cref="CheckPalindromeUseCase"/> logic using a fake dependency.
/// </summary>
public class CheckPalindromeUseCaseTests
{
    /// <summary>
    /// A fake implementation of <see cref="IPalindromeChecker"/> for testing purposes.
    /// Captures the input and returns a configurable result.
    /// </summary>
    private class FakePalindromeChecker : IPalindromeChecker
    {
        public string? ReceivedInput { get; private set; }
        public bool ExpectedResult { get; set; }

        public bool IsPalindrome(string input)
        {
            ReceivedInput = input;
            return ExpectedResult;
        }
    }

    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello", false)]
    public void Execute_ReturnsExpectedResult_AndPassesInputCorrectly(string input, bool expectedResult)
    {
        // Arrange
        var fakeChecker = new FakePalindromeChecker { ExpectedResult = expectedResult };
        var useCase = new CheckPalindromeUseCase(fakeChecker);

        // Act
        var result = useCase.Execute(input);

        // Assert
        Assert.Equal(expectedResult, result);
        Assert.Equal(input, fakeChecker.ReceivedInput);
    }

    [Fact]
    public void Execute_ShouldThrow_WhenInputIsNull()
    {
        // Arrange
        var fakeChecker = new FakePalindromeChecker();
        var useCase = new CheckPalindromeUseCase(fakeChecker);

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => useCase.Execute(null!));
    }
}
