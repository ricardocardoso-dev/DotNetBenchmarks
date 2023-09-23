using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace FindFirstOrDefaultBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class FindFirstOrDefault
    {
        private readonly List<int> numbers;
        private readonly int target;

        public FindFirstOrDefault()
        {
            numbers = Enumerable.Range(1, 10000).ToList();
            target = 5000;
        }

        [Benchmark]
        public int Find()
        {
            return numbers.Find(n => n == target);
        }

        [Benchmark]
        public int FirstOrDefault()
        {
            return numbers.FirstOrDefault(n => n == target);
        }
    }
}
