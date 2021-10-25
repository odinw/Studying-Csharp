namespace Studying_Csharp
{
    /* studying abstract */

    /// <summary>
    /// Define common member & method
    /// </summary>
    public abstract class Car
    {
        public int CC;
        public int Price;

        public virtual string Start()
        {
            return "Engine Start";
        }

        public abstract string Run();
    }

    public class Scooter : Car
    {
        public override string Run()
        {
            return $"{nameof(Scooter)} noraml";
        }
    }

    public class SportsCar : Car
    {
        public override string Run()
        {
            return $"{nameof(SportsCar)} so fast";
        }

        public override string Start()
        {
            return $"{base.Start()} + AI Start";
        }
    }
}
