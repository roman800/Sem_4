using System;

namespace Lab01
{
    public class Calculator
    {
        public double Add(double a, double b)
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

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        //Using Accumulator
        public double Add(double a)
        {
            return a + Accumulator;
        }

        public double Subtract(double a)
        {
            return a - Accumulator;
        }

        public double Multiply(double a)
        {
            return a * Accumulator;
        }

        public double Power(double x)
        {
            return Math.Pow(x, Accumulator);
        }
    }
}