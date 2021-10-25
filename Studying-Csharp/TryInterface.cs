using System;

namespace Studying_Csharp.TryInterface
{
    /* studying interface */

    public interface Read
    {
        public void Paper();
    }

    public interface Write 
    {
        public void Name();
    }

    public class English : Read, Write
    {
        public void Paper()
        {
            Console.WriteLine($"{nameof(English)} {nameof(Paper)}");
        }

        public void Name()
        {
            Console.WriteLine($"{nameof(English)} {nameof(Name)}");
        }
    }
}
