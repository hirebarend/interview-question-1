using InterviewQuestion1.Validators;
using InterviewQuestion1.Validators.Strategies;
using System;

namespace InterviewQuestion1.App
{
    public class Calculator
    {
        protected readonly int _lowerLimit;

        protected readonly int _upperLimit;

        protected readonly Func<string> _read;

        protected readonly Action<string> _write;

        public Calculator(int lowerLimit, int upperLimit, Func<string> read, Action<string> write)
        {
            _lowerLimit = lowerLimit;

            _upperLimit = upperLimit;

            _read = read;

            _write = write;
        }

        public void Run()
        {
            try
            {
                RunOnce();
             }
            catch (Exception ex)
            {
                _write(ex.Message);

                Run();
            }
        }

        protected void RunOnce()
        {
            _write($"Enter a number between {_lowerLimit} and {_upperLimit}: ");

            var input = _read();

            var inputValidator = new InputValidator(input);

            inputValidator
                .AddInputValidatorStrategy(new InputValidatorRequiredStrategy())
                .AddInputValidatorStrategy(new InputValidatorNumericStrategy())
                .AddInputValidatorStrategy(new InputValidatorNumericLimitsStrategy(_lowerLimit, _upperLimit));

            var numericInput = _upperLimit - inputValidator.Validate();

            _write($"{numericInput}");
        }
    }
}
