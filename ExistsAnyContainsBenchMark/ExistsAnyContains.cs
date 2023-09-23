using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ExistsAnyBenchMark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class ExistsAnyContains
    {
        private readonly List<int> numbers;
        private readonly int target;

        public ExistsAnyContains()
        {
            numbers = Enumerable.Range(1, 1000).ToList();
            target = 5000;
        }

        [Benchmark]
        public bool Exists()
        {
            return numbers.Exists(x=> x == target);
        }

        [Benchmark]
        public bool Any()
        {
            return numbers.Any(x => x == target);
        }

        [Benchmark]
        public bool Contains()
        {
            return numbers.Contains(target);
        }
    }
}
