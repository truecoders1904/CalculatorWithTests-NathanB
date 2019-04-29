using System;
namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal Subtract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public decimal Multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public decimal Divide(decimal number1, decimal number2)
        {
            if (number1 == 0 || number2 == 0)
            {
                return 0;
            }
            return number1 / number2;
        }

        public int Factorial(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
              result = i * result;
            }
            return result;
        }
    }
}
