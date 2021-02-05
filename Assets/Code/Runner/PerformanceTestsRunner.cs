using System.Collections.Generic;
using Code.PerformanceTests;

namespace Code.Runner
{
    public sealed class PerformanceTestsRunner
    {
        private readonly int _numberOfIterations;
        private readonly IEnumerable<PerformanceTest> _performanceTests;

        public PerformanceTestsRunner(int numberOfIterations, IEnumerable<PerformanceTest> performanceTests)
        {
            _numberOfIterations = numberOfIterations;
            _performanceTests = performanceTests;
        }

        public void Run()
        {
            foreach (var performanceTest in _performanceTests)
            {
                PerformTests(performanceTest);
            }
        }

        private void PerformTests(PerformanceTest performanceTest)
        {
                performanceTest.Perform(_numberOfIterations);
        }
    }
}
