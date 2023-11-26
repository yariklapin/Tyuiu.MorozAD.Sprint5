using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MorozAD.Sprint5.Task5.V11.Lib;
using System.IO;

namespace Tyuiu.MorozAD.Sprint5.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
