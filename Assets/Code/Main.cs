using System;
using System.Collections.Generic;
using Code.PerformanceTests;
using Code.PerformanceTests.Loops;
using Code.Runner;
using UnityEngine;

namespace Code
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private KeyCode _keyCode = KeyCode.Space;

        private void Start()
        {
            Debug.Log($"Press {_keyCode} to run the configured tests");
        }

        private void Update()
        {
            if (Input.GetKeyDown(_keyCode))
            {
                RunLoopsTests();
            }
        }

        private static void RunLoopsTests()
        {
            const int numberOfIterations = 10000000;

            var loopsPerformanceTests = new PerformanceTest[]
                                        {
                                            new ForeachWithArrayPerformanceTest("Foreach loop using an array"),
                                            new ForWithArrayPerformanceTest("For loop using an array"),
                                            new ForeachWithListPerformanceTest("Foreach loop using a list"),
                                            new ForWithListPerformanceTest("For loop using a list"),
                                            new LinqForWithListPerformanceTest("Linq loop using a list"),
                                        };

            RunTests(numberOfIterations, loopsPerformanceTests);
        }

        private static void RunTests(int numberOfIterations,
                                     IEnumerable<PerformanceTest> performanceTests)
        {
            var performanceTestsRunner = new PerformanceTestsRunner(numberOfIterations, performanceTests);
            performanceTestsRunner.Run();
        }
    }
}
