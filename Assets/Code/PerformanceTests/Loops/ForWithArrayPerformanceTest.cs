namespace Code.PerformanceTests.Loops
{
    public sealed class ForWithArrayPerformanceTest : PerformanceTest
    {
        private int[] _data;

        public ForWithArrayPerformanceTest(string testName) : base(testName)
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
            var dataLength = _data.Length;
            for (var i = 0; i < dataLength; i++)
            {
                accumulateValue += _data[i];
            }
        }
    }
}
