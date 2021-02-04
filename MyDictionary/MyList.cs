using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<TKey, TValue>
    {
        TKey[] key;
        TKey[] tempKey;

        TValue[] value;
        TValue[] tempValue;

        public MyList() //Constructor   
        {
            key = new TKey[0];
            value = new TValue[0];
        }
        public void Add(TKey keyItem, TValue valueItem)
        {
            tempKey = key;
            key = new TKey[key.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }

            key[key.Length - 1] = keyItem;

            tempValue = value;
            value = new TValue[value.Length + 1];

            for (int j = 0; j < tempKey.Length; j++)
            {
                value[j] = tempValue[j];
            }

            value[value.Length - 1] = valueItem;
        }

        public TKey[]  Key { get { return key; } }

        public TValue[] Value { get { return value; } }


    }
}
