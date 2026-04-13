using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POE_Part_1
{
    internal class ClassArray
    {
        public static void displayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"______                
        .-""      ""-.  
       /            \ 
      |              |
      |,  .-.  .-.  ,|
      | )(_ /  \_ )( |
      |/     /\     \|
      (_     ^^     _)
       \__|IIIIII|__/ 
        | \IIIIII/ |  
        \          /  
         `--------`   
  CYBER AWARENESS BOT ");
            Console.ResetColor();

        }

        public static string nameValidation()
        {

            while (true)
            {
                Console.WriteLine("\nHello whats is your name?");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("I didn't quite understand that could you rephrase");
                    continue;
                }

                if (name.Length < 2)
                {
                    Console.WriteLine("Name should be at least two characters long.");
                    continue;
                }

                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Name should only contain alphabets (no numbers or symbols).");
                    continue;
                }

                return name;
            }
        }

        public static void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('=', Console.WindowWidth - 1));
            Console.ResetColor();
        }

        public static void printHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"*\n>>> {title.ToUpper()}<<<");
            Console.ResetColor();
        }

    }
}
