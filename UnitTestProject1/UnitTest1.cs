using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            string l = "Friday";
            string result = ConsoleApp1.Program.Convert(a);
            Assert.AreEqual(5, result);
        }
    }
}