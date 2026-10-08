Random rnd = new Random();

String Play = "Y";

while (Play == "Y")
{
    int chosenNumber = rnd.Next(1, 11);
    int guess = 0;
    int guesses = 0;
    Console.WriteLine("Welcome to the Number Guesser!");
    Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");
    while (guess != chosenNumber)
    {
        guess = int.Parse(Console.ReadLine());
        guesses++;
        if (guess != chosenNumber)
        {
            if (guess > chosenNumber)
            {
                Console.Write("Too high! Try again: ");
            }
            else
            {
                Console.Write("Too low! Try again: ");
            }

        }

    }
    Console.WriteLine("Correct! You guessed the number in " + guesses + " attempts.");
    Console.WriteLine("Play Again? Y/N");
    Play = Console.ReadLine();
}
Console.WriteLine("Goodbye!");
