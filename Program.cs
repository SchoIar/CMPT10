using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static int readNumber()
        {
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        static void print(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            print("Hello! Welcome to lettre grade calculator. Press [ENTER] to continue");
            Console.ReadLine();
            print("The first and only step is to input your grade percentage!");
            Console.ForegroundColor = ConsoleColor.Gray;
            int num = readNumber();
            if (num > 100 || num < 0)
                print("That's an invalid grade!");
            else
                if (num == 100)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                print("Well done! You scored a perfect 100%");
            }
            else
                if (num >= 86)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                print("You got an A. Way to go!");
            }
            else
                if (num >= 73)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                print("You got a B! Nice Job!");
            }
            else
                if (num >= 67)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                print("You got a C+");
            }
            else
            if (num >= 60)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                print("You got a C.");
            }
            else
            if (num >= 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                print("You got a C-");
            }
            else
            if (num < 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                print("Unfortunantally you didn't Pass your course.");
            }
            else
                Console.ForegroundColor = ConsoleColor.Red;
                    print(" Invalid Grade. ");
            Console.ReadLine();
            Console.ResetColor();
            //Main(args);
        }
    }
}
