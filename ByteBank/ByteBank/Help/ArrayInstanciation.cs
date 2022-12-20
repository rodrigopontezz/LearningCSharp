namespace ByteBank.Help
{
    public class ArrayInstanciation
    {
        public Array Instance { get; private set; }

        private int _maxSize;
        private int _currentIndex;

        public ArrayInstanciation(int size)
        {
            Instance = Array.CreateInstance(typeof(double), size);
            _maxSize = size;
        }

        public void AddNumber(double number)
        {
            if (_currentIndex < _maxSize)
            {
                Instance.SetValue(number, _currentIndex);
                _currentIndex++;
            }
        }
    }
}
