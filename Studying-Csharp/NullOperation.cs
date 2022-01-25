namespace Studying_Csharp
{
    public class NullOperation
    {
        public bool IsNull(object data)
        {
            return data is null;
        }

        public bool IsNull_EqualSymbol(object data)
        {
            return data == null;
        }
    }
}
