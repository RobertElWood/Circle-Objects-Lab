namespace Circle_Objects_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;

            int CircleCounter = 0;

            Console.WriteLine("Hello! Welcome to the Circle Calculator!\n");

            while (tryAgain)
            {
                Console.WriteLine("Please enter the radius of the circle you'd like to calculate!\n");

                try
                {
                    double userInput = double.Parse(Console.ReadLine());
                    
                    if (userInput < 0) 
                    {
                        Console.WriteLine("\nI'm sorry, please enter a positive number.\n");
                        continue;
                    }

                    Circle input = new Circle(userInput);

                    Console.WriteLine();

                    Console.WriteLine("Your circumference was: " + input.CalculateCircumference() + "\n");
                    Console.WriteLine("Your area was: " + input.CalculateArea() + "\n");
                } 
                catch (FormatException e)
                {
                    Console.WriteLine("\nI'm sorry, you didn't enter valid data. Please enter a number.\n");
                    continue;
                }

                CircleCounter++;

                tryAgain = RunAgain(CircleCounter);
        
            }

        }

        public static bool RunAgain(int CircleCounter)
        {
            Console.WriteLine("\nWould you like to create another circle? Y/N?\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine();
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nGoodbye! You created " + CircleCounter + " Circle object(s).");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand that. Please try again!");
                return RunAgain(CircleCounter);
            }
        }
    }
}

