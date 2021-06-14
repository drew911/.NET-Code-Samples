using System;
using System.Collections.Generic;

namespace MyFirstConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
           

            InputProcessor inputProcessor = new InputProcessor();
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter expression");
            var consoleInput = Console.ReadLine(); // 5 + 5

           
            InputModel parsedInput = inputProcessor.ProcessInput(consoleInput);

            var number = calculator.ProcessCalculation(parsedInput);

            Console.WriteLine(number);
        }
    }
}
