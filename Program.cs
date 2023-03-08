using System;

namespace Legio_Victrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = Environment.UserName;
            bool shutdown = false;
            bool foundResponse;
            string inputValue;
            string outputValue = "";
            string aiName = "Legio Victrix";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(aiName + ": Hello");
            Console.ResetColor();

            while (!shutdown)
            {
                foundResponse = false;
                Console.WriteLine(userName);
                inputValue = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(aiName + ": ");
                Console.ResetColor();

                //response

                switch (inputValue)
                {
                    case "hello":
                    outputValue = "Hello to you! How are you?";
                    foundResponse = true;
                    break;

                    case "exit":                
                    Console.WriteLine("Good bye");
                    Thread.Sleep(3000);
                    //Console.ReadKey();
                    Environment.Exit(0);
                    break;
                    
                    case "what is the meaing of life":
                    outputValue = "I really dont know!";
                    foundResponse = true;
                    break;

                    case "i am gay":
                    outputValue = "its good to be gay";
                    foundResponse = true;
                    break;

                }

                // if response is found
                if (foundResponse)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(outputValue);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("boi you stupid please rephrase that?");
                    Console.ResetColor();
                }
            }
        }
    }
}