using InterviewQuestion1.Validators.Interfaces;
using System;

namespace InterviewQuestion1.Validators.Strategies
{
    public class InputValidatorNumericStrategy : IInputValidatorStrategy
    {
        public string Validate(string input)
        {
            if (!int.TryParse(input, out var inputNumber))
            {
                throw new Exception("input needs to be a number");
            }

            return input;
        }
    }
}
