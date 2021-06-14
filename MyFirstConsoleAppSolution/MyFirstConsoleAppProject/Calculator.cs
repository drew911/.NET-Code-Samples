using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAppProject
{
    public class Calculator
    {
        public int ProcessCalculation(InputModel inputModel)
        {
            switch (inputModel.Operation)
            {
                case '+':
                    return inputModel.FirstNumber + inputModel.SecondNumber;
                case '-':
                    return inputModel.FirstNumber - inputModel.SecondNumber;
                case '*':
                    return inputModel.FirstNumber * inputModel.SecondNumber;
                default:
                    return 0;
            }
        }
    }
}
