using System;
using System.Collections.Generic;

namespace Studying_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum_IsDefine();
            //ForLoop_Special();
            List_Remove();
        }

        // List.Remove() & List.RemoveAt(), it will be change data structure
        static void List_Remove()
        {
            var list = new List<int> { 1, 3, 5, 7, 9};
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"before {i} : {list[i]}");

            list.Remove(5);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"Remove(5) {i} : {list[i]}");

            list.RemoveAt(2);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"RemoveAt(2) {i} : {list[i]}");

        }

        static void ForLoop_Special()
        {
            for (int i = 0, j = 1, k = 2; i < 1; i++)
                Console.WriteLine($"multivariable: {i}, {j}, {k}");

            // always false
            for (int i = 0; i < 0; i++)
                Console.WriteLine(i);

            for (int i = 0; false; i++)
                Console.WriteLine(i);

            int index = 0;

            // early define index
            for (index = 0; index < 0; index++)
                Console.WriteLine(index);

            // early define index & no default index
            for (; index < 0; index++)
                Console.WriteLine(index);

            // early define index & no default index & no default iteration 
            for (; index < 0;)
                Console.WriteLine(index);
            
            // it can work, but it is infinite loop 
            // for (;;) Console.WriteLine(index);
        }

        static void Enum_IsDefine()
        {
            Console.WriteLine(Enum.IsDefined(typeof(Status), 1));
            Console.WriteLine(Enum.IsDefined(typeof(Status), 5));

            // 強塞
            Status status = (Status)5;
            Console.WriteLine(Enum.IsDefined(typeof(Status), status));
        }

        enum Status
        {
            Open = 1,
            Close = 2
        }
    }
}
