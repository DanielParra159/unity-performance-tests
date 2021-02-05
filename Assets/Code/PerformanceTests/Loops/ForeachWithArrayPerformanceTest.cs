namespace Code.PerformanceTests.Loops
{
    public sealed class ForeachWithArrayPerformanceTest : PerformanceTest
    {
        private int[] _data;

        public ForeachWithArrayPerformanceTest(string testName) : base(testName)
        {
        }

        protected override void SetUp(int numberOfIterations)
        {
            _data = new int[numberOfIterations];
            for (var i = 0; i < numberOfIterations; i++)
            {
                _data[i] = i;
            }
        }

        protected override void PerformTest()
        {
            var accumulateValue = 0;

            foreach (var i in _data)
            {
                accumulateValue += i;
            }
        }
    }
}
