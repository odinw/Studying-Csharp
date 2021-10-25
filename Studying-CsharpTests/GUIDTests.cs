using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class GUIDTests
    {
        [TestMethod()]
        public void StringTest()
        {
            var guid = new GUID();
            Console.WriteLine(guid.Print);
            Console.WriteLine(guid.Format_D);
            Console.WriteLine(guid.Format_N);
            Console.WriteLine(guid.Format_B);
            Console.WriteLine(guid.Format_P);
            Console.WriteLine(guid.Format_X);

            Console.WriteLine("Length:");
            Console.WriteLine(guid.Print.Length);
            Console.WriteLine(guid.Format_D.Length);
            Console.WriteLine(guid.Format_N.Length);
            Console.WriteLine(guid.Format_B.Length);
            Console.WriteLine(guid.Format_P.Length);
            Console.WriteLine(guid.Format_X.Length);
        }
    }
}