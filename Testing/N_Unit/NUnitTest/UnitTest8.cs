using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    internal class UnitTest8
    {
        [TestFixture]
        public class FileProcessorTests
        {
            private FileProcessor processor;
            private string fileName;

            [SetUp]
            public void Setup()
            {
                processor = new FileProcessor();
                fileName = "testfile.txt";
            }

            [TearDown]
            public void TearDown()
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
            }

            [Test]
            public void WriteAndRead_ShouldReturnCorrectContent()
            {
                processor.WriteToFile(fileName, "Hello NUnit");

                string result = processor.ReadFromFile(fileName);

                Assert.AreEqual("Hello NUnit", result);
            }

            [Test]
            public void WriteToFile_ShouldCreateFile()
            {
                processor.WriteToFile(fileName, "Sample");

                Assert.IsTrue(File.Exists(fileName));
            }

            [Test]
            public void ReadFromFile_FileDoesNotExist_ShouldThrowIOException()
            {
                Assert.Throws<IOException>(() =>
                {
                    processor.ReadFromFile("missing.txt");
                });
            }
        }
    }
}
