using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;



namespace Nunit_MSTest
{
    internal class Program7
    {
        public class TaskRunner
        {
            public string LongRunningTask()
            {
                Thread.Sleep(3000);
                return "Completed";
            }
        }
}
