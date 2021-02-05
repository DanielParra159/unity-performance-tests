using System.Collections.Generic;

namespace Code.PerformanceTests.Loops
{
    public sealed class ForWithListPerformanceTest : PerformanceTest
    {
        private List<int> _data;

        public ForWithListPerformanceTest(string testName) : base(testName)
        {
        }

        protected override void SetUp(int numberOfIterations)
        {
            _data = new List<int>(numberOfIterations);
            for (var i = 0; i < numberOfIterations; i++)
            {
                _data.Add(i);
            }
        }

        protected override void PerformTest()
        {
            var accumulateValue = 0;
            var dataCount = _data.Count;

            for (var i = 0; i < dataCount; i++)
            {
                accumulateValue += _data[i];
            }
        }
    }
}
