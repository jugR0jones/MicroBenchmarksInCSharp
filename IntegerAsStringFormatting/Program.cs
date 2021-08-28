using BenchmarkDotNet.Running;
using IntegerAsStringFormatting.Benchmarks;
using IntegerAsStringFormatting.Demo;

namespace IntegerAsStringFormatting
{
    internal static class Program
    {
        private static void Main()
        {
//            FixedWidthFormatterDemo.Run();

            BenchmarkRunner.Run<FixedWidthFormatterBenchmarks>();
        }
    }
}