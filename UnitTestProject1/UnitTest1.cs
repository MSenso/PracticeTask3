using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTask3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            form.x = 0.4;
            form.y = 0.1;
            form.U_Calculation();

            form.x = -0.4;
            form.y = 0.1;
            form.U_Calculation();

            form.x = 0;
            form.y = 1;
            form.U_Calculation();

            form.x = 0.703;
            form.y = 0.495;
            form.U_Calculation();

            form.x = -0.703;
            form.y = 0.495;
            form.U_Calculation();
        }
    }
}
