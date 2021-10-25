using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Studying_Csharp.TryInterface.Tests
{
    [TestClass()]
    public class EnglishTests
    {
        [TestMethod]
        public void EnglishTest()
        {
            English english = new English();
            english.Paper();
            english.Name();
        }
    }
}
