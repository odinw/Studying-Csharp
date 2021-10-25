using System;

namespace Studying_Csharp.TryInterfaceAbstract
{
    /* studying interface + abstract + multi-inheritance */

    public interface Read
    {
        public void Paper();
    }

    public interface Write
    {
        public void Name();
    }

    public abstract class English
    {
        public abstract void Communication();
    }

    public class People : English, Write, Read
    {
        public override void Communication()
        {
            Console.WriteLine(nameof(Communication));
        }

        public void Paper()
        {
            Console.WriteLine(nameof(Paper));
        }

        public void Name()
        {
            Console.WriteLine(nameof(Name));
        }
    }

}
