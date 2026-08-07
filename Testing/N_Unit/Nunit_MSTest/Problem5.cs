using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_MSTest
{
    internal class Problem5
    {
        public bool Connected { get; private set; }

        public void Connect()
        {
            Connected = true;
        }


        public void Disconnect()
        {
            Connected = false;
        }
    }
}
