``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i5-1035G1 CPU 1.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.102
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|   Method |     Mean |    Error |   StdDev |
|--------- |---------:|---------:|---------:|
|      Add |       NA |       NA |       NA |
| AsyscAdd | 26.28 ms | 0.270 ms | 0.253 ms |

Benchmarks with issues:
  TestEF.Add: DefaultJob
