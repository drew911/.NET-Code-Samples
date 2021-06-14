using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAppProject
{
    public class InputProcessor
    {
        public InputModel ProcessInput(string calculationString)
        {
            //500+5,80- 88, 9- 3

            //0. Remove all empty spaces
            calculationString = calculationString.Replace(" ", "");

            //1. Find position of first non-number

            char nonNumericValue = calculationString.First(c => !Char.IsDigit(c));

            //int position = calculationString.IndexOf(nonNumericValue);

            //2. Split string into 3 parts on that position.
            String[] numbers = calculationString.Split(nonNumericValue);

            //3. Int.Parse both numbers.

            int number1 = Int32.Parse(numbers[0]);
            int number2 = Int32.Parse(numbers[1]);

            //4 Map information to InputModel

            return new InputModel
            {
                FirstNumber = number1,
                SecondNumber = number2,
                Operation = nonNumericValue
            };
        }
    }
}
