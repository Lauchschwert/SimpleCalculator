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
            





            Console.WriteLine("Pick your first number."); 
            int number1 = Convert.ToInt32(Console.ReadLine());          // Picks your first number
            Console.WriteLine("Pick your second number.");
            int number2 = Convert.ToInt32(Console.ReadLine());          // Picks your second number
            Console.WriteLine("What do you want to do with your numbers? (Divide: D / Add: A / Subtract: S / Multiply: M)");            // asks you what you want to do with the two numbers
            ConsoleKeyInfo level = Console.ReadKey(true);

            switch (level.KeyChar)                                      // specified on higher cased keys
            {
                case 'D':
                    float outputD = number1 / number2;
                    Console.WriteLine("Equals "+outputD+".");
                    break;                                  
                case 'A':
                    float outputA = number1 + number2;
                    Console.WriteLine("Equals: "+outputA+".");
                    break;                                              // Picks what method you want to use your numbers in
                case 'S':
                    float outputS = number1 - number2;
                    Console.WriteLine("Equals "+outputS+".");
                    break;
                case 'M':
                    float outputM = number1 * number2;
                    Console.WriteLine("Equals "+outputM+".");
                    break;
            }
            switch (level.KeyChar)                                      // specified on lower cased keys
            {
                case 'd':
                    float outputD = number1 / number2;
                    Console.WriteLine("Equals " + outputD + ".");
                    break;
                case 'a':
                    float outputA = number1 + number2;
                    Console.WriteLine("Equals: " + outputA + ".");
                    break;                                              // Picks what method you want to use your numbers in
                case 's':
                    float outputS = number1 - number2;
                    Console.WriteLine("Equals " + outputS + ".");
                    break;
                case 'm':
                    float outputM = number1 * number2;
                    Console.WriteLine("Equals " + outputM + ".");
                    break;
            }


        }
    }
}
