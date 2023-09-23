using BenchmarkDotNet.Running;
using ExistsAnyBenchMark;

internal class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<ExistsAnyContains>();
    }
}