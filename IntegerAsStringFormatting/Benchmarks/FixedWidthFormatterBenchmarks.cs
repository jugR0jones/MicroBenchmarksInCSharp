using BenchmarkDotNet.Attributes;
using IntegerAsStringFormatting.Classes;

namespace IntegerAsStringFormatting.Benchmarks
{
    [MemoryDiagnoser]
    public class FixedWidthFormatterBenchmarks
    {
        [Benchmark]
        public void BenchmarkOutputAs000Method_0()
        {
            string output = FixedWidthFormatter.OutputAs000(0);
        }
        
        [Benchmark]
        public void BenchmarkOutputAs000Method_1()
        {
            string output = FixedWidthFormatter.OutputAs000(1);
        }
        
        [Benchmark]
        public void BenchmarkOutputAs000Method_12()
        {
            string output = FixedWidthFormatter.OutputAs000(12);
        }
        
        [Benchmark]
        public void BenchmarkOutputAs000Method_123()
        {
            string output = FixedWidthFormatter.OutputAs000(123);
        }
        
        [Benchmark]
        public void BenchmarkOutputAs000Method_999()
        {
            string output = FixedWidthFormatter.OutputAs000(999);
        }
    }
}