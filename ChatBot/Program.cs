using System;

namespace ChatBotNumberOne
{
        class MainClass
        {



        public static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello Freind; What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("How're you doing today " + name + " ?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "Good":
                case "Okay":
                    Console.WriteLine("Great, glad to hear that!");
                    break;
                case "Bad":
                    Console.WriteLine("Well.. Thats why your here for theropy");
                    break;
                default:
                    Console.WriteLine("I didnt catch that.. Anyways are you here for theropy");
                    string input2 = Console.ReadLine();
                    switch (input2.ToLower())
                    {
                        case "Yea":
                        case "Yes":
                            Console.WriteLine("Great! Your at the right place " + name + ".");
                            break;
                        case "no":
                            Console.WriteLine("Oups.. Then your in the wrong place.");
                            break;
                        default:
                            Console.WriteLine("I'm sorry, I don't understand that!");
                            break;
                    }
                    break;
            }
        }
    }
}
