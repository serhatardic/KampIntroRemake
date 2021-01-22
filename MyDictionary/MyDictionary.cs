using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] key;
        T2[] value;
        T1[] tempKey;
        T2[] tempValue;

        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];

        }
        public void Add(T1 keys, T2 values)
        {
            tempKey = key;
            tempValue = value;
            key = new T1[key.Length + 1];
            value = new T2[value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
            Console.WriteLine("dictionary element has been created!");
        }
        public int Count 
        {
            get { return key.Length; }
            
        }
    }
}
