using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class UnitTest7
    {
        [TestFixture]
        public class TaskRunnerTests
        {
            private TaskRunner runner;

            [SetUp]
            public void Setup()
            {
                runner = new TaskRunner();
            }

            [Test]
            [Timeout(2000)]
            public void LongRunningTask_ShouldFailIfExceeds2Seconds()
            {
                runner.LongRunningTask();
            }
        }
    }
}
