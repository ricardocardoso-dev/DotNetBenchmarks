```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
  [Host]             : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256 [AttachedDebugger]
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256


```
| Method         | Job                | Runtime            | Mean      | Error     | StdDev    |
|--------------- |------------------- |------------------- |----------:|----------:|----------:|
| Find           | .NET 5.0           | .NET 5.0           |  7.432 μs | 0.1325 μs | 0.1175 μs |
| FirstOrDefault | .NET 5.0           | .NET 5.0           | 30.085 μs | 0.4263 μs | 0.3987 μs |
| Find           | .NET 6.0           | .NET 6.0           |  6.238 μs | 0.0992 μs | 0.0928 μs |
| FirstOrDefault | .NET 6.0           | .NET 6.0           | 28.523 μs | 0.2849 μs | 0.2665 μs |
| Find           | .NET Framework 4.8 | .NET Framework 4.8 |  7.427 μs | 0.1195 μs | 0.1118 μs |
| FirstOrDefault | .NET Framework 4.8 | .NET Framework 4.8 | 26.656 μs | 0.2716 μs | 0.2408 μs |
