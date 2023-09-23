```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
  [Host]             : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256 [AttachedDebugger]
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256


```
| Method   | Job                | Runtime            | Mean       | Error    | StdDev   |
|--------- |------------------- |------------------- |-----------:|---------:|---------:|
| Exists   | .NET 5.0           | .NET 5.0           | 1,524.4 ns | 14.20 ns | 13.29 ns |
| Any      | .NET 5.0           | .NET 5.0           | 6,098.8 ns | 43.57 ns | 38.63 ns |
| Contains | .NET 5.0           | .NET 5.0           |   186.8 ns |  1.57 ns |  1.47 ns |
| Exists   | .NET 6.0           | .NET 6.0           | 1,283.7 ns |  9.09 ns |  8.50 ns |
| Any      | .NET 6.0           | .NET 6.0           | 5,895.1 ns | 40.79 ns | 38.15 ns |
| Contains | .NET 6.0           | .NET 6.0           |   147.3 ns |  0.94 ns |  0.84 ns |
| Exists   | .NET Framework 4.8 | .NET Framework 4.8 | 1,311.2 ns | 13.14 ns | 12.29 ns |
| Any      | .NET Framework 4.8 | .NET Framework 4.8 | 5,593.3 ns | 60.45 ns | 56.54 ns |
| Contains | .NET Framework 4.8 | .NET Framework 4.8 | 1,300.2 ns | 16.22 ns | 15.17 ns |
