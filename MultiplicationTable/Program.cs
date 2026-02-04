namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int firstNumber, secondNumber;

            Console.WriteLine("please enter your first number");
            userInput = Console.ReadLine();
            firstNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {firstNumber}");

            Console.WriteLine("please enter your second number");
            userInput = Console.ReadLine();
            secondNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {secondNumber}");

            {
                for (int row = 1; row < firstNumber + 1; row++)
                {
                    for (int column = 1; column < secondNumber + 1; column++)
                    {
                        Console.Write((row * column).ToString().PadLeft(5));
                    }
                    Console.WriteLine();
                }
                //pause
                Console.Read();
            }
        }
    }
}
