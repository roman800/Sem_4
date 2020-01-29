using System;

namespace Lab01
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            Accumulator = result;
            return result;
        }


        public double Accumulator { get; private set; }
    }
}