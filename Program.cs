using System;

namespace Legio_Victrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool shutdown = false;
            bool foundResponse;
            string inputValue;
            string outputValue = "";
            string aiName = "Legio Victrix";

            Console.WriteLine(aiName + ": Hello");

            while (!shutdown)
            {
                foundResponse = false;
                Console.WriteLine("User:");
                inputValue = Console.ReadLine().ToLower();
                
                Console.WriteLine(aiName + ": ");

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
                }

                // if response is found
                if (foundResponse)
                {
                    Console.WriteLine(outputValue);
                }
                else
                {
                    Console.WriteLine("I do not understand. Can you please rephrase it?");
                }
            }
        }
    }
}
