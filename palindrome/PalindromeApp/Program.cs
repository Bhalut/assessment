using PalindromeApp.Application;
using PalindromeApp.Domain;

// Display prompt to user
Console.WriteLine("Enter a string to check if it's a palindrome:");
var input = Console.ReadLine();

// Validate user input
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Input cannot be empty.");
    return;
}

// Create dependencies manually (no DI container used here)
IPalindromeChecker checker = new PalindromeChecker();
var useCase = new CheckPalindromeUseCase(checker);

// Try executing the use case and handle any unexpected errors
try
{
    bool isPalindrome = useCase.Execute(input!);
    Console.WriteLine($"Is Palindrome? {(isPalindrome ? "Yes" : "No")}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
