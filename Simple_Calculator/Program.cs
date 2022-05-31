using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            // Customization

            Console.BackgroundColor = ConsoleColor.Black;               // change "Black" to any Color to change the backgroundcolor obvious
            Console.ForegroundColor = ConsoleColor.DarkGreen;           // change "DarkGreen" to any Color to change the Color og the letters

                // code
            Console.WriteLine("(If you want to Substract 2 Numbers, remember that your first number must be higher than the second number.)\n");

            Console.WriteLine("Pick your first number.");
            int number1 = Convert.ToInt32(Console.ReadLine());          // Picks your first number
                    
            Console.WriteLine("\n");

            Console.WriteLine("Pick your second number.");
            int number2 = Convert.ToInt32(Console.ReadLine());          // Picks your second number
            
            Console.WriteLine("\n");

            Console.WriteLine("What do you want to do with your numbers? (Divide: D / Add: A / Subtract: S / Multiply: M)\n");            // asks you what you want to do with the two numbers
            
            ConsoleKeyInfo level = Console.ReadKey(true);
            switch (level.KeyChar)                                      // specified on higher cased keys
            {
                case 'D':
                    float outputD = number1 / number2;
                    Console.WriteLine("Dividing...\n");
                    Console.WriteLine("\nEquals " + outputD+".");
                    break;

                case 'A':
                    float outputA = number1 + number2;
                    Console.WriteLine("Adding...\n");
                    Console.WriteLine("\nEquals: " + outputA+".");     // Picks what method you want to use your numbers in
                    break; 
                                                                
                case 'S':
                    float outputS = number1 - number2;
                    Console.WriteLine("Substracting...\n");
                    Console.WriteLine("\nEquals " + outputS+".");
                    break;

                case 'M':
                    float outputM = number1 * number2;
                    Console.WriteLine("Multiplying...\n");
                    Console.WriteLine("\nEquals "+outputM+".");
                    break;
            }
            switch (level.KeyChar)                                      // specified on lower cased keys
            {
                case 'd':
                    float outputD = number1 / number2;
                    Console.WriteLine("Dividing...\n");
                    Console.WriteLine("\nEquals " + outputD + ".");
                    break;
                case 'a':
                    float outputA = number1 + number2;
                    Console.WriteLine("Adding...\n");
                    Console.WriteLine("\nEquals: " + outputA + ".");
                    break;                                              // Picks what method you want to use your numbers in
                case 's':
                    float outputS = number1 - number2;
                    Console.WriteLine("Substracting...\n");
                    Console.WriteLine("\nEquals " + outputS + ".");
                    break;
                case 'm':
                    float outputM = number1 * number2;
                    Console.WriteLine("Multiplying...\n");
                    Console.WriteLine("\nEquals " + outputM + ".");
                    break;
            }

            Console.WriteLine("\nPress any Key to Exit the Program.");
            Console.ReadKey();


        }
    }
}
