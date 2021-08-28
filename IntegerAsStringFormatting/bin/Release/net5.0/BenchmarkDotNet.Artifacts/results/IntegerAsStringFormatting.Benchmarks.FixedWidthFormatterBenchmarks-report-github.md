``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1110 (20H2/October2020Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.201
  [Host]     : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
  DefaultJob : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT


```
|                         Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|------------------------------- |---------:|---------:|---------:|-------:|----------:|
|   BenchmarkOutputAs000Method_0 | 23.11 ns | 0.242 ns | 0.226 ns | 0.0102 |      64 B |
|   BenchmarkOutputAs000Method_1 | 21.80 ns | 0.430 ns | 0.683 ns | 0.0102 |      64 B |
|  BenchmarkOutputAs000Method_12 | 21.60 ns | 0.148 ns | 0.132 ns | 0.0102 |      64 B |
| BenchmarkOutputAs000Method_123 | 21.60 ns | 0.393 ns | 0.307 ns | 0.0102 |      64 B |
| BenchmarkOutputAs000Method_999 | 21.64 ns | 0.273 ns | 0.228 ns | 0.0102 |      64 B |
