using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            x = 5;
            Assert.IsTrue(x == 5, "Test successfully");
        }
    }
}
