using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MSTest
{
    internal class MSTest8
    {
        [TestClass]
        public class FileProcessorTests
        {
            string file = "test.txt";

            FileProcessor processor;


            [TestInitialize]
            public void Setup()
            {
                processor = new FileProcessor();
            }


            [TestCleanup]
            public void Cleanup()
            {
                if (File.Exists(file))
                    File.Delete(file);
            }


            [TestMethod]
            public void Write_Read_File_Test()
            {
                processor.WriteToFile(file, "Hello MSTest");

                string result = processor.ReadFromFile(file);

                Assert.AreEqual("Hello MSTest", result);
            }


            [TestMethod]
            public void File_ShouldExist_AfterWriting()
            {
                processor.WriteToFile(file, "Test");

                Assert.IsTrue(File.Exists(file));
            }


            [TestMethod]
            [ExpectedException(typeof(IOException))]
            public void Read_MissingFile_ShouldThrowException()
            {
                processor.ReadFromFile("abc.txt");
            }
        }
}
