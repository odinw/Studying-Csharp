using System;

namespace Studying_Csharp
{
    public class InheritanceChain { }

    public class Toy
    {
        public virtual string GetName()
        {
            Console.WriteLine(nameof(Toy));
            return nameof(Toy);
        }
    }

    public class LAGO : Toy
    {
        public override string GetName()
        {
            base.GetName();
            Console.WriteLine(nameof(LAGO));
            return nameof(LAGO);
        }
    }

    public class Robot : LAGO
    {
        public override string GetName()
        {
            base.GetName();
            Console.WriteLine(nameof(Robot));
            return nameof(Robot);
        }
    }
}
