using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Studying_Csharp.TryInterfaceAbstract.Tests
{
    [TestClass()]
    public class PeopleTests
    {
        [TestMethod()]
        public void CommunicationTest()
        {
            People people = new People();
            people.Communication();
        }

        [TestMethod()]
        public void PaperTest()
        {
            People people = new People();
            people.Paper();
        }

        [TestMethod()]
        public void NameTest()
        {
            People people = new People();
            people.Name();
        }
    }
}