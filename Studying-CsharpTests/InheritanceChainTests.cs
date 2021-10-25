using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class InheritanceChainTests
    {
        [TestMethod]
        public void Toy_Robot()
        {
            Toy toy = new Robot();
            toy.GetName();
        }

        [TestMethod]
        public void LAGO_Robot()
        {
            LAGO lago = new Robot();
            lago.GetName();
        }

        [TestMethod]
        public void Robot_Robot()
        {
            Robot robot = new Robot();
            robot.GetName();
        }
    }
}