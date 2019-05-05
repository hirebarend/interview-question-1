using InterviewQuestion1.Validators;
using InterviewQuestion1.Validators.Strategies;
using System;

namespace InterviewQuestion1.App
{
    public class Calculator
    {
        protected int _lowerLimit;

        protected int _upperLimit;

        protected Func<string> _read;

        protected Action<string> _write;

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
