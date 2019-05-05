using InterviewQuestion1.Validators.Interfaces;
using System;

namespace InterviewQuestion1.Validators.Strategies
{
    public class InputValidatorRequiredStrategy : IInputValidatorStrategy
    {
        public string Validate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("input is required");
            }

            return input;
        }
    }
}
