using System;

namespace Studying_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum_IsDefine();
            SpecialForLoop();
        }

        static void SpecialForLoop()
        {
            for (int i = 0, j = 1, k = 2; i < 1; i++)
                Console.WriteLine($"muilt-value: {i}, {j}, {k}");

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
