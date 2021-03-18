using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmsLesson7Task;

namespace TestGetCountWay
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCountWayMethod_10x10()
        {
            int M = 10;
            int N = 10;

            int extends = 48620;

            int actual = Program.GetCountWay(N, M);

            Assert.AreEqual(extends, actual);
        }

        [TestMethod]
        public void TestGetCountWayMethod_3x3()
        {
            int M = 3;
            int N = 3;

            int extends = 6;

            int actual = Program.GetCountWay(N, M);

            Assert.AreEqual(extends, actual);
        }
    }
}
