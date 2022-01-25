using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying_Csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class NullOperationTests
    {
        [TestMethod()]
        [DataRow(null, true)]
        [DataRow(0, false)]
        [DataRow("", false)]
        public void IsNullTest(object input, bool expected)
        {
            // Arrange
            var nullOperation = new NullOperation();

            // Act
            var actual = nullOperation.IsNull(input);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void EqualSymbol_True()
        {
            // Arrange
            var nullOperation = new NullOperation();

            // Act
            var actual = nullOperation.IsNull_EqualSymbol(null);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow("")]
        public void EqualSymbol_False(object input)
        {
            // Arrange
            var nullOperation = new NullOperation();

            // Act
            var actual = nullOperation.IsNull_EqualSymbol(input);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}