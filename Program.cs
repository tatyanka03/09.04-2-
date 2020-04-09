using System;
using System.Collections.Generic;

namespace itProger2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> digits = new List<short>() { 1, 0, 93, 75 };
            digits.Add(5);
            digits.AddRange(new short[] { 7, 8, 45 });
            digits.Insert(1, 178);
            digits.Remove(0);
            digits.RemoveAt(2);
            digits.Sort();
            Console.WriteLine(digits[2]);

            Console.ReadKey();

        }
    }
}
