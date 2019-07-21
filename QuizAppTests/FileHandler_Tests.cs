using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Core;
using System.IO;
using NUnit.Framework;

namespace QuizAppTests
{
    [TestFixture]
    public class FileHandler_Tests
    {
        FileHandler fh;
        string result;
        string expected;

        [SetUp]
        public void Init()
        {
            fh = new FileHandler();
        }
        [Test]
        public void FileHandler_isNotNull()
        {            
            Assert.IsNotNull(fh);
        }
        [Test]
        public void When_FileHandler_Path_IsCalled_Expect_Empty_string()
        {            
            result = fh.Path;
            expected = "";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_FileHandler_Path_IsCalled_Expect_string_Path()
        {            
            fh.Path = @"C:/SomeDirectories";
            result = fh.Path;
            expected = @"C:/SomeDirectories";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_FileHandler_FileName_Is_Called_Expect_Empty_string()
        {            
            result = fh.FileName;
            expected = "";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_FileHandler_FileName_Is_Set_Expect_FileName_To_Return_string()
        {
            fh.FileName = "someFile.txt";
            result = fh.FileName;
            expected = "someFile.txt";
            Assert.AreEqual(expected, result);
        }
    }
}
