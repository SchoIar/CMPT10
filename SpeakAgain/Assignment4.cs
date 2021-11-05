using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SpeakAgain
{
    class Program
    {
        static bool CheckLanguage(string message)
        {
            string[] dictionary = { "HECK", "darn", "poop", "fuck", "ass" };
            foreach (string word in dictionary)
            {
                if (message.ToLower().Contains(word) == true)
                {
                    // a banned word is detected
                    return false;
                }

            }

            return true; // language in message is appropriate.
        }

        static void print(string s)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            Console.WriteLine(s);
            synthesizer.Speak(s);
        }

        static void Main(string[] args)
        {
            String message;
            string input;
            string repeat;
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            print("Hello. I'm a therapist bot, Im here for you so feel free to tell me all your problems. So tell me, what's your name? ");


            message = Console.ReadLine();
            if (CheckLanguage(message) == true)
            {
                print("Nice to meet you " + message + ", So what would you like to tell me ? ");

            }
            else
            {
                message = "Im sorry.. \"" + message + "\" is not appropriate.  ";
                Console.WriteLine(message);
                synthesizer.Speak("Im sorry that word is not appropriate. ");
                print(" What would you like to tell me today? ");
            }
            repeat = "";
            input = "";
            input = Console.ReadLine();

            Random Ran = new Random();
            int Int1 = Ran.Next(0, 6);
            while (input != "bye" || input != "exit")
            {
                if (input == repeat) ;
                {
                    print("Your repeating yourself.");
                }
                if (input == "")
                {
                    repeat = input;
                    print("This silence is getting awkward. Please say something or else Im giving up on you.");
                    input = Console.ReadLine();
                }
                else
                if (CheckLanguage(input) == false)
                {
                    repeat = input;
                    print("That's a forbidden word. ");
                    Int1 = Ran.Next(0, 6);
                }
                else
                if (input != message || repeat != input)
                {
                    if (Int1 == 1)
                    {
                        repeat = input;
                        print("I see, Go on.");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 2)
                    {
                        repeat = input;
                        print("Thats very intresting " + message + " . ");
                        print(" Anyways, Is there anything else that you'd like to tell me today");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 3)
                    {
                        repeat = input;
                        print("You said \"" + input + "\" what do you mean ?");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 4)
                    {
                        repeat = input;
                        print("Continue. Im taking notes, but im also listening. ");
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 5)
                    {
                        repeat = input;
                        print("Why do you feel that way, " + message + " . ");
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    {
                        repeat = input;
                        print(" What exactally do you mean my'dud ? ");
                        Int1 = Ran.Next(0, 6);
                    }

                }
                else
                {
                    repeat = input;
                    print(" Are you feeling okay?");
                    Int1 = Ran.Next(0, 6);
                }
            }



            print("Txt");

            Console.ReadLine();

        }
    }
}

