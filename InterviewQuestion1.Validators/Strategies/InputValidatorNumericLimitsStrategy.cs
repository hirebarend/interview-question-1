using InterviewQuestion1.Validators.Interfaces;
using System;

namespace InterviewQuestion1.Validators.Strategies
{
    public class InputValidatorNumericLimitsStrategy : IInputValidatorStrategy
    {
        protected int _lowerLimit;

        protected int _upperLimit;

        public InputValidatorNumericLimitsStrategy(int lowerLimit, int upperLimit)
        {
            _lowerLimit = lowerLimit;

            _upperLimit = upperLimit;
        }

        public string Validate(string input)
        {
            var inputNumber = int.Parse(input);

            if (inputNumber < _lowerLimit)
            {
                throw new Exception($"input needs to be greater than or equal to {_lowerLimit}");
            }

            if (inputNumber > _upperLimit)
            {
                throw new Exception($"input needs to be less than or equal to {_upperLimit}");
            }


            return input;
        }
    }
}
