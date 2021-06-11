using System;
using System.Collections.Generic;

namespace MyFirstConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console based calculator
            //Calculator should be simple just add/subtract
            //Possible inputs: 5 + 6, 0 - 2
            // Outputs result
            // The calculator should keep running until 'exit' is typed

            InputProcessor inputProcessor = new InputProcessor();
            Calculator calculator = new Calculator();

            var consoleInput = Console.ReadLine(); // 5 + 5

            // Convert to more suitable format
            InputModel parsedInput = inputProcessor.ProcessInput(consoleInput);

            //
            var number = calculator.ProcessCalculation(parsedInput);

            Console.WriteLine(number);
        }
    }
}
