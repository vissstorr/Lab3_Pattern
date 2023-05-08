using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    public static class Cheaking
    {
        public static int ChekingValue(string value)
        {
            int type;
            while (!Int32.TryParse(value, out type))
            {
                Console.Write("\tВведенно не коректно тип даниих, ведіть ще раз : ");
                value = Console.ReadLine();
            }
            return type;
        }
    }
}
