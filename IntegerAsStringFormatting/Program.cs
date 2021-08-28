using BenchmarkDotNet.Running;
using IntegerAsStringFormatting.Benchmarks;

namespace IntegerAsStringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var summaryReport = BenchmarkRunner.Run<FixedWidthFormatterBenchmarks>();
        }
    }
}