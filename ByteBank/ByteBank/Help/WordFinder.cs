namespace ByteBank.Help
{
    public class WordFinder
    {

        public string[] Words { get; private set; }

        private int _currentSize;
        private int _maxSize;


        /// <summary>
        /// Define the constructor with the string array size.
        /// </summary>
        /// <param name="size">Inform the size of the Words array.</param>
        public WordFinder(int size)
        {
            Words = new string[size];
            _maxSize = size;
        }


        public void AddWord(string wordToAdd)
        {
            if (_currentSize < _maxSize)
            {
                Words[_currentSize] = wordToAdd;
                _currentSize++;
            }
            else
            {
                Console.WriteLine("It was not possible to include the word because the array is full.");
            }
        }


        public void FindWord(string wordToSearch)
        {
            bool wordFound = false;

            foreach (string word in Words)
            {
                if (word.Equals(wordToSearch))
                {
                    wordFound = true;
                    break;
                }
            }

            if (wordFound)
            {
                Console.WriteLine($"The word {wordToSearch} was found in the array!");
            }
            else
            {
                Console.WriteLine($"The word {wordToSearch} was not found, please try again.");
            }
        }


        public void ListWords()
        {
            Console.WriteLine("List of words:\n");

            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
