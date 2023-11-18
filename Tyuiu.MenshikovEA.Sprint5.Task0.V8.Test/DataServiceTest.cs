using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint5.Task0.V8.Lib;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:Users\mensh\source\repos\Tyuiu.MenshikovEA.Sprint5\Tyuiu.MenshikovEA.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
