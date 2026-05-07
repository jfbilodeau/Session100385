// Create a new Random instance to generate random numbers
Random random = new();
// Generate a random secret number between 1 and 100 (inclusive)
int secretNumber = random.Next(1, 101);
// Initialize the player's guess to 0
int guess = 0;
// Initialize the attempt counter to track how many guesses the player makes
int attempts = 0;

// Display welcome message to the player
Console.WriteLine("Welcome to the Number Guess Game!");
// Inform the player about the range of the secret number
Console.WriteLine("I'm thinking of a number between 1 and 100.");
// Ask the player to start guessing
Console.WriteLine("Can you guess it?\n");

// Continue the game loop until the player guesses the correct number
while (guess != secretNumber)
{
    // Prompt the player to enter their guess
    Console.Write("Enter your guess: ");
    // Read input from the player
    string? input = Console.ReadLine();
    
    // Check if input is null (EOF reached)
    if (input == null)
    {
        Console.WriteLine("\nGame ended. No more input available.");
        break;
    }
    
    // Try to parse the user's input as an integer and store it in the guess variable
    if (int.TryParse(input, out guess))
    {
        // Increment the attempts counter for each valid guess
        attempts++;

        // Check if the guess is less than the secret number
        if (guess < secretNumber)
        {
            // Inform the player their guess was too low
            Console.WriteLine("Too low! Try again.\n");
        }
        // Check if the guess is greater than the secret number
        else if (guess > secretNumber)
        {
            // Inform the player their guess was too high
            Console.WriteLine("Too high! Try again.\n");
        }
        // The guess matches the secret number
        else
        {
            // Display congratulations message with the secret number and total attempts
            Console.WriteLine($"\nCongratulations! You guessed the number {secretNumber} in {attempts} attempts!");
        }
    }
    // Handle the case where the input is not a valid integer
    else
    {
        // Display an error message asking for a valid number
        Console.WriteLine("Invalid input. Please enter a valid number.\n");
    }
}
