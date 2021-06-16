using System;

namespace Studying_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum_IsDefine();
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
