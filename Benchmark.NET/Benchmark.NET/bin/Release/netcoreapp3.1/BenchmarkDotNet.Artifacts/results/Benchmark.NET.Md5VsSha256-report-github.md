``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
| Method |      Mean |     Error |    StdDev |
|------- |----------:|----------:|----------:|
| Sha256 |  8.934 us | 0.1173 us | 0.1097 us |
|    Md5 | 22.744 us | 0.4480 us | 0.5502 us |
