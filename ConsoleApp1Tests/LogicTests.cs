using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void fivePairs()
        {
            string text = "asd daaffaf a ff a f fad dasasaafasdss";
            string message = Logic.CountPairs(text);
            Assert.AreEqual("Кол-во пар одинаковых соседних букв: 5", message);
        }

        [TestMethod()]
        public void nonePairs()
        {
            string text = "gdhugdl glhifgdhfgd g h42342342342";
            string message = Logic.CountPairs(text);
            Assert.AreEqual("Кол-во пар одинаковых соседних букв: 0", message);
        }

        [TestMethod()]
        public void ninePairs()
        {
            string text = "7435o7y4gh5 7hg45 tyhgy45t hogh 4otgy 4o8754 g4ho87o458 o87gh4o4ghgggggssasaasdfso74gh54gh54 7 sfsdddd784tgh7t4ohto74tg4o 45gt5o4t go4";
            string message = Logic.CountPairs(text);
            Assert.AreEqual("Кол-во пар одинаковых соседних букв: 9", message);
        }
    }
}