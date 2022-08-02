using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_Csharp.Tests
{
    [TestClass()]
    public class LoopAndSwitchCaseContinue
    {
        [TestMethod()]
        public void LoopAndSwitchCaseContinueTest()
        {
            // arrange
            var data = new List<int> { 1, 2, 3};
            // act
            data.ForEach(x =>
            {
                Console.WriteLine($"now: {x}");
                var max = 10;
                var counter = 0;
                while (counter++ < max)
                {
                    switch(x)
                    {
                        case 1:
                            Console.WriteLine(x);
                            continue; // 會跳過此回合，所以不會印出 "while last 1"
                        case 2:
                            Console.WriteLine(x);
                            continue;
                        case 3:
                            Console.WriteLine(x);
                            break;
                    }
                    Console.WriteLine("while last 1");
                }
                Console.WriteLine("while end");

            });
            Console.WriteLine("loop end");
            // assert
        }
    }
}
