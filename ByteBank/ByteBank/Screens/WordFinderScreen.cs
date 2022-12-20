using ByteBank.Help;

namespace ByteBank.Screens
{
    public class WordFinderScreen
    {

        private readonly WordFinder _wordFinder = new(5);

        public void DisplayOptions()
        {
            PrintAvailableOperations();
            SelectOperation();
        }

        private static void PrintAvailableOperations()
        {
            Console.WriteLine("Welcome to the Word Finder!\n");
            Console.WriteLine("1 - Add Word");
            Console.WriteLine("2 - Search Word");
            Console.WriteLine("3 - List Words");
            Console.WriteLine("0 - Exit\n");
        }

        private void SelectOperation()
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                try
                {
                    Console.Clear();
                    PrintAvailableOperations();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.Write("Please inform the word to add in the array: ");
                            _wordFinder.AddWord(Console.ReadLine());
                            break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            Console.Write("Please inform the word to look for: ");
                            _wordFinder.FindWord(Console.ReadLine());
                            break;
                        case ConsoleKey.D3:
                            Console.Clear();
                            _wordFinder.ListWords();
                            break;
                        case ConsoleKey.D0:
                            Console.WriteLine("Thanks for using the Word Finder!\n");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"UNKNOWN ERROR: {ex.Message}");
                }
            }
            while (keyInfo.Key != ConsoleKey.D0);
        }
    }
}
