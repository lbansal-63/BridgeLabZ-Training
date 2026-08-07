using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Nunit_MSTest
{
    internal class Program3
    {
        public void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }

        public void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}
