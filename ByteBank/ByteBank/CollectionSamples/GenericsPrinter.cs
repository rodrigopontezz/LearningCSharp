namespace ByteBank.CollectionSamples
{
    public class GenericsPrinter<T>
    {

        public static void PrintValue(T value)
        {
            Console.WriteLine($"The value is {value}.");
        }
    }
}
