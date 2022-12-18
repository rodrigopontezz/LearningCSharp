namespace _4_Caracteres
{
    class Program
    {
        
        private string escola = "";

        static void Main(string[] args)
        {
            Console.WriteLine("4 - Caracteres");

            char letra = 'a';

            letra = (char) 53;

            letra = (char) (44 + 33);

            Console.WriteLine(letra);

            string textoComMultiplasLinhas = @"Eu
quero
uma
palavra
por
linha";

            Console.WriteLine(textoComMultiplasLinhas);

            Console.ReadKey();

        }



        static bool isMaiorDeIdade(int idade)
        {
            bool result = false;

            if (idade > 18)  result = true;

            return result;
        }
    }
}