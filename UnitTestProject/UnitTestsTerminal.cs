using Microsoft.VisualStudio.TestTools.UnitTesting;
using TerminalKFC.Windows;
using System.Windows;
using System.Windows.Controls;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestsTerminal
    {
        Window2 wnd = new Window2();

        [TestMethod]
        public void SumTestAllTerminal()
        {
            int sum, price, expectedSum, resultSum;

            // 1 test
            sum = 200;
            price = 70;

            expectedSum = 270;
            resultSum = wnd.GetNewSum(sum, price);

            Assert.AreEqual(expectedSum, resultSum);

            // 2 test
            sum = 0;
            price = 200;

            expectedSum = 200;
            resultSum = wnd.GetNewSum(sum, price);

            Assert.AreEqual(expectedSum, resultSum);

            // 3 test
            sum = 200;
            price = 100;

            expectedSum = 300;
            resultSum = wnd.GetNewSum(sum, price);

            Assert.AreEqual(expectedSum, resultSum);

            // 4 test
            sum = 300;
            price = 150;

            expectedSum = 450;
            resultSum = wnd.GetNewSum(sum, price);

            Assert.AreEqual(expectedSum, resultSum);

            // 5 test
            sum = 450;
            price = 200;

            expectedSum = 650;
            resultSum = wnd.GetNewSum(sum, price);

            Assert.AreEqual(expectedSum, resultSum);
        }

        [TestMethod]
        public void TestShefBurger()
        {
            wnd.AddNewProduct("Шефбургер\t\t\t100 p.");
            StringAssert.Contains(wnd.bracket, "Шефбургер\t\t\t100 p.");
        }

        [TestMethod]
        public void TestMilkSheik()
        {
            wnd.AddNewProduct("Милкшейк\t\t\t\t200 p.");
            StringAssert.Contains(wnd.bracket, "Милкшейк\t\t\t\t200 p.");
        }

        [TestMethod]
        public void TestBigPirog()
        {
            wnd.AddNewProduct("Пирог\t\t\t\t150 p.");
            StringAssert.Contains(wnd.bracket, "Пирог\t\t\t\t150 p.");
        }

        [TestMethod]
        public void TestSmallPirog()
        {
            wnd.AddNewProduct("Пирожок\t\t\t70 p.");
            StringAssert.Contains(wnd.bracket, "Пирожок\t\t\t70 p.");
        }
    }
}