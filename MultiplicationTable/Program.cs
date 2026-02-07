/* 
Hunter Clezie 
Spring 2026
RCET2265
MultiplicationTable
github url: https://github.com/hunterclezie-pixel/MultiplicationTable.git
*/
namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userInput = "";
            int result = 0;
            bool isValid = false;

            do
            {
                Console.WriteLine("Please enter a Number between 1-12 for the Table");
                Console.WriteLine("Enter \"D\" for the default table of 12x12"); 
                userInput = Console.ReadLine();
                Console.Clear();

                //Accept 'D' or 'd' for default 12x12 grid
                if (userInput == "D" || userInput == "d")
                {
                    Console.WriteLine($"You've selected the default 12 x 12 multiplication table!");
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

                //Try to parse numeric input and validate number range 1-12
                else if (int.TryParse(userInput, out int parsed))
                {
                    if (parsed >= 1 && parsed <= 12)
                    {
                    Console.WriteLine($"You've selected the custom {userInput} x {userInput} multiplication table!");
                        for (int row = 1; row <= parsed; row++)
                        {
                            for (int column = 1; column <= parsed; column++)
                            {
                                Console.Write((row * column).ToString().PadLeft(5));
                            }
                                Console.WriteLine();
                            }
                            isValid = true;
                    }
                    else
                    {
                        //Makes sure the number is between 1 and 12 and prompts the user to try again if it's not
                        Console.WriteLine("Number must be between 1 and 12. Please try again.");
                        isValid = false;
                    }

                }

                //Stops the program from crashing if the user enters something other than a number or 'D'
                else
                {
                    Console.WriteLine($"Thid is not a valid input, please try again");
                    isValid = false;
                }
            } while (isValid == false);

            //pause
            Console.Read();
        }
    }
}
