using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint5.Task4.V27.Lib;
using System.IO;

namespace Tyuiu.MorozAD.Sprint5.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Артём\source\repos\Tyuiu.MorozAD.Sprint5\Tyuiu.MorozAD.Sprint5.Task4.V27\bin\Debug\OutPutFileTask4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
