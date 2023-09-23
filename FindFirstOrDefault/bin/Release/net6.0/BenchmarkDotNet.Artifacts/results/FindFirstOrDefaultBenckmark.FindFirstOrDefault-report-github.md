```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100-rc.1.23455.8
  [Host]     : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2


```
| Method               | Mean      | Error     | StdDev    |
|--------------------- |----------:|----------:|----------:|
| FindMethod           |  7.556 μs | 0.1148 μs | 0.1074 μs |
| FirstOrDefaultMethod | 30.391 μs | 0.5655 μs | 0.5554 μs |
