using System;

namespace ChatBot
{
    class MainClass
    {
        static void print(string s)
        {
            Console.WriteLine(s);
        }

        public static void Main(string[] args)
        {

            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }



            String Name;
            Console.ForegroundColor = ConsoleColor.Green;
            print("Greetings. Whats your name? ");
            Console.ResetColor();
            Name = Console.ReadLine();

            //print("How are you feeling " + Name + " ?")
            Console.ForegroundColor = ConsoleColor.Green;
            print("How are you feeling today " + Name + " ? ");
            Console.ResetColor();
            String Hello = Console.ReadLine();
            switch (Hello)
            {
                case "Good":
                case "Excellent":
                    Console.ForegroundColor = ConsoleColor.Green;
                    print("Thats nice. What would you like to talk about today?");
                    Console.ResetColor();
                    break;
                case "Decent":
                case "okay":
                    Console.ForegroundColor = ConsoleColor.Green;
                    print("Okay. Hopefully you'll feel nice after your Theropy");
                    print("Anyways, Lets get back on track. Why are you here for today's session?");
                    Console.ResetColor();
                    string input2 = Console.ReadLine();
                    switch (input2.ToLower())
                    {
                        case "Im Stressed":
                        case "Im Depressed":
                        case "Im needing help":
                            Console.ForegroundColor = ConsoleColor.Green;
                            print("Sad to hear that. What's making you feel this emotion? ");
                            print("Do you have issues at work? Or maybe at home? ");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            print("Sorry; I don't understand you. Please repeat that. Did you just say that you're Sad?");
                            Console.ResetColor();
                            break;
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    print("Can you repeat that ? Your being unclear. ");
                    Console.ResetColor();
                    break;
            }
            Console.ReadLine();
        }
        //Main[args];
    }
}
