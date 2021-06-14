using System;
using System.Collections.Generic;

namespace MyFirstConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            while (command != "Exit")
            {
                InputProcessor inputProcessor = new InputProcessor();
                Calculator calculator = new Calculator();

                Console.WriteLine("Enter expression");
                var consoleInput = Console.ReadLine(); // 5 + 5

                InputModel parsedInput = inputProcessor.ProcessInput(consoleInput);

                var number = calculator.ProcessCalculation(parsedInput);

                Console.WriteLine(number);
                Console.WriteLine("Type 'Exit' if you want to exit or any button to continue");
                command = Console.ReadLine();
            }
        }
    }
}
