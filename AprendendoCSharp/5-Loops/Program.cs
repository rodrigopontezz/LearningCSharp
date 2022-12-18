namespace _5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 - Laços de repetição");

            short i = 0;

            while (i < 10)
            {
                Console.WriteLine("Contador: " + i++);
            }

            for (short idade = 1; idade <= 30; idade++)
            {
                if (idade < 18)
                {
                    Console.WriteLine("Você tem " + idade + " e é MENOR de idade.");
                }
                else
                {
                    Console.WriteLine("Você tem " + idade + " e é MAIOR de idade.");
                }
            }
        }
    }
}