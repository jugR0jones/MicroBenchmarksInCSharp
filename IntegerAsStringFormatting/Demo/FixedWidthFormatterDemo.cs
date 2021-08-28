using System;
using IntegerAsStringFormatting.Classes;

namespace IntegerAsStringFormatting.Demo
{
    public class FixedWidthFormatterDemo
    {
        public static void Run()
        {
            string output = FixedWidthFormatter.OutputAs000(0);
            Console.WriteLine("0 => " + output);

            output = FixedWidthFormatter.OutputAs000(1);
            Console.WriteLine("1 => " + output);

            output = FixedWidthFormatter.OutputAs000(12);
            Console.WriteLine("12 => " + output);

            output = FixedWidthFormatter.OutputAs000(123);
            Console.WriteLine("123 => " + output);

            output = FixedWidthFormatter.OutputAs000(999);
            Console.WriteLine("999 => " + output);
        }
    }
}