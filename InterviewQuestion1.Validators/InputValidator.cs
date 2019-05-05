using InterviewQuestion1.Validators.Interfaces;
using System.Collections.Generic;

namespace InterviewQuestion1.Validators
{
    public class InputValidator
    {
        protected string _input;

        protected IList<IInputValidatorStrategy> _inputValidatorStrategies;

        public InputValidator(string input)
        {
            _input = input;

            _inputValidatorStrategies = new List<IInputValidatorStrategy>();
        }

        public InputValidator AddInputValidatorStrategy(IInputValidatorStrategy inputValidatorStrategy)
        {
            _inputValidatorStrategies.Add(inputValidatorStrategy);

            return this;
        }

        public int Validate()
        {
            foreach (var inputValidatorStrategy in _inputValidatorStrategies)
            {
                _input = inputValidatorStrategy.Validate(_input);
            }

            return int.Parse(_input);
        }
    }
}
