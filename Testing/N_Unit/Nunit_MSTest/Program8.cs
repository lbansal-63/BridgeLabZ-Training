using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_MSTest
{
    internal class Program8
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }


        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("File not found");

            return File.ReadAllText(filename);
        }
    }
}
