namespace _3_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - Casting");

            short inteiroPequeno    = 16000;
            int inteiroMediano      = 1000000000;
            long inteiroLongo       = 1000000000000000000;
            ulong inteiroUltraLongo = 10000000000000000000;

            Console.WriteLine(inteiroPequeno);
            Console.WriteLine(inteiroMediano);
            Console.WriteLine(inteiroLongo);
            Console.WriteLine(inteiroUltraLongo);

            float flutuantePequeno  = 10.2f;
            double flutuanteMediano = 10.2;
            decimal flutuanteLongo  = 10.2m;

            Console.WriteLine(flutuantePequeno);
            Console.WriteLine(flutuanteMediano);
            Console.WriteLine(flutuanteLongo);

            int inteiroCast = (int) flutuanteLongo;

            Console.WriteLine(inteiroCast);

            Console.ReadKey();
        }
    }
}