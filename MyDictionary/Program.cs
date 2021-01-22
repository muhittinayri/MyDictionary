using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "Muhittin");
            dictionary.Add(1, "Ali");
            dictionary.Add(2, "Mehmet");
            dictionary.Add(3, "Gönül");
            dictionary.Out();


        }
    }

    class Dictionary<T, V>
    {
        T[] Key;
        V[] Value;

        public Dictionary()
        {
            Key = new T[0];
            Value = new V[0];
        }

        public void Add(T t, V v)
        {
            T[] _tempKey = Key;
            V[] _tempValue = Value;
            Key = new T[Key.Length + 1];
            Value = new V[Value.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                Key[i] = _tempKey[i];
                Value[i] = _tempValue[i];
            }
            Key[Key.Length - 1] = t;
            Value[Value.Length - 1] = v;
        }


        public void Out()
        {
            for (int i = 0; i < Key.Length; i++)
            {
                Console.WriteLine(Key[i] + " is the key and " + Value[i] + " is the value of that key.");
            }
        }



        public int Count
        {
            get { return Value.Length; }
        }

    }
}
