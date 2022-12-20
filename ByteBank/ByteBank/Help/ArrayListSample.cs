using System.Collections;

namespace ByteBank.Help
{
    public class ArrayListSample
    {
        public ArrayList Items = new ArrayList();

        public ArrayListSample()
        {
            Items.Add("An ArrayList can be used without knowing its items data types.");
            Items.Add(50.2);
            Items.Add(true);
            Items.RemoveAt(1);
            Items.IndexOf(50.2);
            Items.Clear();
        }
    }
}
