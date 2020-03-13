using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;

namespace CalcTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calc_2plus2equal4()
        {
            double x = 10;
            double y = 20;
            double expected = 30;
            Calc c = new Calc();
            double actual = c.Sum(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_20minus10equal0()
        {
            double x = 20;
            double y = 10;
            double expected = 10;
            Calc c = new Calc();
            double actual = c.Minus(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_20mul10equa200()
        {
            double x = 20;
            double y = 10;
            double expected = 200;
            Calc c = new Calc();
            double actual = c.Mult(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_20dev10equa2()
        {
            double x = 20;
            double y = 10;
            double expected = 2;
            Calc c = new Calc();
            double actual = c.dev(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_5sinequa2()
        {
            double x = 0;
            double expected = 0;
            Calc c = new Calc();
            double actual = c.sin(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_0cosequa1()
        {
            double x = 0;
            double expected = 1;
            Calc c = new Calc();
            double actual = c.cos(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_0tgequa0()
        {
            double x = 0;
            double expected = 0;
            Calc c = new Calc();
            double actual = c.tg(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calc_1logequa0()
        {
            double x = 1;
            double expected = 0;
            Calc c = new Calc();
            double actual = c.log(x);
            Assert.AreEqual(expected, actual);
        }
        public void calc_fact5equal120()
        {
            double x = 5;
            double expected =120;
            Calc c = new Calc();
            double actual = c.fakt(x);
            Assert.AreEqual(expected, actual);
        }
        public void calc_koren16equal4()
        {
            double x = 16;
            double expected = 4;
            Calc c = new Calc();
            double actual = c.Xkoren2(x);
            Assert.AreEqual(expected, actual);
        }
        public void calc_2and2equa4()
        {
            double x = 2;
            double expected = 4;
            Calc c = new Calc();
            double actual = c.X2(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
