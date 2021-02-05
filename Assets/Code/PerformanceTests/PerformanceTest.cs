using UnityEngine.Profiling;

namespace Code.PerformanceTests
{
    public abstract class PerformanceTest
    {
        public readonly string TestName;

        protected PerformanceTest(string testName)
        {
            TestName = testName;
        }
        
        public void Perform(int numberOfIterations)
        {
            SetUp(numberOfIterations);
            
            Profiler.BeginSample($"PerformanceTest: {TestName}");
            PerformTest();
            Profiler.EndSample();
        }

        protected abstract void SetUp(int numberOfIterations);
        protected abstract void PerformTest();
    }
}
