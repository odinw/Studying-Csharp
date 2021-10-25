using System;

namespace Studying_Csharp.TryInterface
{
    /* studying interface */

    public interface Read
    {
        //*** 貌似可用 virtual 實作內容
        public virtual void Add(int a, int b)
        {
            //Console.WriteLine(nameof(Read));
            Console.WriteLine(a + b);
        }

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

    //*** 等待研究複雜一點的 Interface + Abstract + Multi-Inheritance
    //public abstract class English
    //{
    //    public abstract void Communication();
    //}

    //public class People : English, Write, Read
    //{
    //    public override void Communication()
    //    {

    //    }
    //}

}
