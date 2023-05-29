using System;
using System.ComponentModel;

namespace CalculatorLib
{
    public class CalculatorFunc
    {
        private double _currentValue = 0.0;
        private char _lastOperator = ' ';

        public double CurrentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }

        public char LastOperator
        {
            get { return _lastOperator; }
            set { _lastOperator = value; }
        }

        public double Result()
        {
            return _currentValue;
        }

        public double Calculate(double value, char op)
        {
            switch (_lastOperator)
            {
                case ' ':
                    _currentValue = value;
                    break;
                case '+':
                    _currentValue += value;
                    break;
                case '-':
                    _currentValue -= value;
                    break;
                case '*':
                    _currentValue *= value;
                    break;
                case '/':
                    if (value == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    _currentValue /= value;
                    break;
            }
            return _currentValue;
            _lastOperator = op;
        }

        public void Clear()
        {
            _currentValue = 0.0;
            _lastOperator = ' ';
        }

    }
}

