namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNuber);
                if (isValid)
                {
                    if (playerNuber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNuber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if (playerNuber < computerNumber)
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }
        }
    }
}