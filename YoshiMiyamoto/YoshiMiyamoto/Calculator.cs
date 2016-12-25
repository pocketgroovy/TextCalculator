using System;

namespace YoshiMiyamoto
{
    public class Calculator
    {
        string[] items;
        
        public Calculator(string[] items)
        {
            this.items = items;
        }

        public double getResult()
        {
            int length = items.Length - 1;
            double result = Double.Parse(items[0]);
            string operate = items[length];
            if(operate == "Addition")
            {
                for (int i = 1; i < length; i++)
                {
                    result += Double.Parse(items[i]);
                }
            }
            else if(operate == "Subtraction")
            {
                for (int i = 1; i < length; i++)
                {
                    result-= Double.Parse(items[i]);
                }
            }
            else if(operate == "Division")
            {
                for (int i = 1; i < length; i++)
                {
                    if(items[i] == "0")
                    {
                        throw new DivideByZeroException();
                    }
                    result /= Double.Parse(items[i]);
                }
            }
            else if(operate == "Multiplication")
            {
                for (int i = 1; i < length; i++)
                {
                    result *= Double.Parse(items[i]);
                }
            }
            else
            {
                throw new Exception("Unknown Operation found");
            }

            if(result < 0)
            {
                throw new Exception("The result became below zero");
            }
 
            return result;
        }
    }
}
