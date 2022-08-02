using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Studying_Csharp
{
    public class TryArrray
    {
        public void Show()
        {
            Array array = new int[3];

            Console.WriteLine("origin:");
            foreach (var item in array)
                Console.WriteLine(item);

            Console.WriteLine("modify:");
            array.SetValue(1, 1);
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
