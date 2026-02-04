namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userInput = "";
            int result = 0;
            bool isValid = false;
            int firstNumber, secondNumber;

            do
            {
                Console.WriteLine("Please enter a Number between 1-12 for the Table");
                Console.WriteLine("Enter \"D\" for the default table of 12x12"); 
                userInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You enter {userInput}");

                try
                {
                    // this is the code for selecting your own size of grid
                    for (int row = 1; row < int.Parse(userInput) + 1; row++)
                    {
                        for (int column = 1; column < int.Parse(userInput) + 1; column++)
                        {
                            Console.Write((row * column).ToString().PadLeft(5));
                        }
                        Console.WriteLine();
                        isValid = true;
                    }

                }
                catch (Exception ex)
                {
                    //This is the selection for a 12 by 12 grid by default
                    if (userInput == "D" || userInput == "d") 
                    {
                        Console.WriteLine($"You've selected the 12x12 multiplication table!");
                        for (int row = 1; row < 12 + 1; row++)
                        {
                            for (int column = 1; column < 12 + 1; column++)
                            {
                                Console.Write((row * column).ToString().PadLeft(5));
                            }
                            Console.WriteLine();
                            isValid = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Thid is not a valid input, please try again");
                            isValid = false;
                        }
                    }
                } while (isValid == false);

                //pause
                Console.Read();
            }
        }
    }
