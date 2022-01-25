using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class TryDataAnnotationsTests
    {
        [TestMethod()]
        public void 必要欄位_不給值_會如何_Test()
        {
            var contact = new TryDataAnnotations();
            //contact.Age = 50;
            //contact.Name

            var context = new ValidationContext(contact, null, null);
            var errors = new List<ValidationResult>();
            var result = Validator.TryValidateObject(contact, context, errors, true);

            Assert.IsTrue(result);
        }
    }
}
