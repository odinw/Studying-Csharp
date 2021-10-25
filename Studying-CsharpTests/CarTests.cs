using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void StartTest()
        {
            Car car1 = new Scooter();
            Console.WriteLine(car1.Start());

            Car car2 = new SportsCar();
            Console.WriteLine(car2.Start());

            Scooter scooter = new Scooter();
            Console.WriteLine(scooter.Start());

            SportsCar sportsCar = new SportsCar();
            Console.WriteLine(sportsCar.Start());
        }
    }
}