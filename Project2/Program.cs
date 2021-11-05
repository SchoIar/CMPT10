using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void print(string x)
        {
            Console.WriteLine(x);
        }


        static double ReadNumber(string y)
        {
            Console.Write(y);
            double num = double.Parse(Console.ReadLine());
            return num;
        }


        static string inputName(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }

        static double Number1(string y)
        {
            Console.Write(y);
            double num1 = double.Parse(Console.ReadLine());
            return num1;
        }

        static double Number2(string y)
        {
            Console.Write(y);
            double num2 = double.Parse(Console.ReadLine());
            return num2;
        }


        static void Main(string[] args)
        {
        //The colors represent the parts of the assignment. Cyan's part one green's part two.
            Console.ForegroundColor = ConsoleColor.Cyan;

            string str = inputName("What is your name : ");
            double year = ReadNumber("What year were you born in : ");
            if (year > 2018)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                print("You don't exist yet. Why didn't you come to Stephen Hawking's Time travel party?");
            }
            else
            if (year == 2018) {
                Console.ForegroundColor = ConsoleColor.Red;
                print("Your ZERO years old... back away from the computer");
            }
            else
            print(str + " is " + (2018 - year) + " or " + (2017 - year) + " years old."  );
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            double num1 = Number1("Entre your first number : ");
            double num2 = Number2("Entre your second number : ");
            print("The sum of your numbers is " + (num1 + num2));
            print("The product of your numbers is " + (num1 * num2));
            if (num1 == num2)
            {
                print("The diffence of the two equal numbers is zer0. It's quotiens is one. ");
            }

            else
                print("The possible diffrences of the numbers are " + (num1 - num2) + " and " + (num2 - num1));
            print("The possible quotients of the numbers are " + (num2 / num1) + " and " + (num1 / num2));
            Console.ReadLine();
        }
    }
}

