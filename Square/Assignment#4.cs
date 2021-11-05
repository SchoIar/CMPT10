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
            string[] dictionary = { "heck", "darn", "poop", "fuck", "ass" };
            foreach (string word in dictionary)
            {
                if (message.ToLower().Contains(word) == true)
                {
                    return false;
                }

            }
            return true;
        }

        static bool CheckLanguage2(string input)
        {
            string[] dictionary = { "heck", "darn", "poop", "fuck", "ass" };
            foreach (string word in dictionary)
            {
                if (input.ToLower().Contains(word) == true)
                {
                    return false;
                }

            }
            return true;
        }


        static bool Language(string input)
        {
            string[] dictionary = { "bye", "exit", "leave", "quit" };
            foreach (string word in dictionary)
            {
                if (input.ToLower().Contains(word) == true)
                {
                    return false;
                }

            }
            return true;
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
            string REPEATname;
            bool shutdown = false;
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            print("Hello. I'm a therapist bot, Im here for you so feel free to tell me all your problems. So tell me, what's your name? ");
            Console.WriteLine("");

            message = Console.ReadLine();
                     while (message == "")
                     {

                    print("\nIm sorry, Could you repeat that, I didn't catch your name.");
                    Console.WriteLine("");
                REPEATname = Console.ReadLine();
                     }

                     if (message == "Dick"|| message == "Ass" || message == "Fuck" || message == "Slut" || message == "Ela" || message == "Asshole" || message == "Bitch" || message == "Whore" )
                     {
                message = "Swear Guy";
               
                     }
                    

            if (CheckLanguage(message) == true)
                      {
                          print("\nNice to meet you " + message + ", So what would you like to tell me ? ");
                             Console.WriteLine("");
                        }
                      else
                      {
                         message = "\nIm sorry.. \"" + message + "\" is not appropriate.  ";
                        Console.WriteLine(message);
                          synthesizer.Speak("\nIm sorry that word is not appropriate. ");
                          print("\nWhat would you like to tell me today? ");
                         Console.WriteLine("");
            }
            repeat = ".";
            input = "";
            input = Console.ReadLine();
            shutdown = false;

            Random Ran = new Random();
            int Int1 = Ran.Next(0, 6);
            while (shutdown == false)
            {
                string LowerRepeat = input.ToLower();
                string LowerInput = repeat.ToLower();

                if (Language(input) == false)
                {
                    shutdown = true;
                }
                if (CheckLanguage2(input) == false)
                {
                    repeat = input;
                    print("\nThat's a forbidden word.");
                    Console.WriteLine("");
                    input = Console.ReadLine();
                }
                else
                   
                if (LowerRepeat == LowerInput || repeat == "") 
                // REMINDER - Need to find a way to find if theyre both to lower
                {
                    repeat = input; 
                    print("\nYour repeating yourself. tell me something else.");
                    Console.WriteLine("");
                    input = Console.ReadLine();
                    Int1 = Ran.Next(0, 6);
                }
                else
                if (CheckLanguage(input) == false)
                {
                    repeat = input;
                    print("\nThat's a forbidden word. ");
                    Console.WriteLine("");
                    input = Console.ReadLine();
                    Int1 = Ran.Next(0, 6);
                }
                else
                if (input == "")
                {
                    repeat = input;
                    print("\nThis silence is getting awkward. Please say something or else Im giving up on you.");
                    Console.WriteLine("");
                    input = Console.ReadLine();
                    Int1 = Ran.Next(0, 6);
                }
                else
                if (input != message || repeat != input)
                {
                    if (Int1 == 0)
                    {
                        repeat = input;
                        print("\nCan you paraphrase that?");
                        Console.WriteLine("");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                      if (Int1 == 1)
                    {
                        repeat = input;
                        print("\nI see, Go on.");
                        Console.WriteLine("");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 2)
                    {
                        repeat = input;
                        print("\nThats very intresting " + message + " . ");
                        print("\nWhat else do you want to talk about " + message + " ");
                        Console.WriteLine("");
                        input = Console.ReadLine();
                        if (input == "no")
                        {
                            Console.WriteLine("\nOkay. In that case I shall see you later. ");
                            Console.WriteLine("");
                            shutdown = true;
                        }
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 3)
                    {
                        repeat = input;
                        print("\nYou said \"" + input + "\" what do you mean ?");
                        Console.WriteLine("");
                        input = Console.ReadLine();
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 4)
                    {
                        repeat = input;
                        print("\nContinue. Im taking notes, but im also listening. ");
                        Console.WriteLine("");
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    if (Int1 == 5)
                    {
                        repeat = input;
                        print("\nWhy do you feel that way, " + message + " ? ");
                        Console.WriteLine("");
                        Int1 = Ran.Next(0, 6);
                    }
                    else
                    {
                        repeat = input;
                        print("\nWhat exactally do you mean my'dud ? ");
                        Console.WriteLine("");
                        Int1 = Ran.Next(0, 6);
                    }

                }
                else
                {
                    repeat = input;
                    print("\nCan you paraphrase that?");
                    Console.WriteLine("");
                    Int1 = Ran.Next(0, 6);
                }
            }



            print("\nBye " + message + ".");

            Console.ReadLine();

            }
        }
    }


