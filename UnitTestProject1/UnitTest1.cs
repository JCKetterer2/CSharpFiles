using Microsoft.VisualStudio.TestTools.UnitTesting;
using week1.Fundamentals;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dinosaur dino = new Dinosaur();
            string result = dino.Teeth;

            Assert.AreNotEqual("Yes", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Dinosaur dino = new Dinosaur();
            dino.Size = 50;

            Assert.AreSame(50, dino.Size);
        }
    }
}
