using System;

namespace Week8.CalculatorWinForm.Core
{
    public class Calculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double? Divide(double a, double b)
        {
            return (b == 0) ? null : a / b;
            //(condizione) ? risultatoSeVero : risultatoSeFalso 
        }
    }
}
