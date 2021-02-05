# unity performance tests
Do you have doubts about what is more optimal? Or which function consumes the most memory?
Is it better to use for, foreach or linq? What about Lists vs Arrays?
We have all heard claims that one thing is better than another, but how many times have we checked for ourselves?

This project is created to give answers to these types of questions quickly and easily. Simply create your test with the function you want to test and the results will automatically be displayed in the Unity profiles.

![Profiler](https://github.com/DanielParra159/unity-performance-tests/blob/main/Screenshots/Profiler.png)

# How to use this project
To add a test you need to inherit from PerformanceTest and implement SetUp and PerformTest functions. Then you need to create a PerformanceTestsRunner, or use an existing PerformanceTestsRunner, and add our test.
The last step is to run the tests from the Main.cs script (just follow the example :D ).

You can fork this project, or you can create a pull request with your tests and share it.

# Nice feateres to have
- Add categories for the PerformanceTest and auto-configure a PerformanceTestsRunner for each category with these tests.
- Avoid the need to modify Main.cs script to add more runners. A solution using reflection would be interesting (or any solution that does not require modifying this script to add tests)
