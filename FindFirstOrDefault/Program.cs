using BenchmarkDotNet.Running;
using FindFirstOrDefaultBenchmark;

internal class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<FindFirstOrDefault>();
    }
}