using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    internal class MSTest7
    {
        [TestClass]
        public class TaskRunnerTests
        {
            [TestMethod]
            [Timeout(2000)]
            public void LongRunningTask_Test()
            {
                TaskRunner task = new TaskRunner();

                task.LongRunningTask();
            }
        }
    }
}
