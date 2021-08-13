using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyArray;
        TValue[] valueArray;

        public MyDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] keyTemp = keyArray;
            TValue[] valueTemp = valueArray;

            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < keyTemp.Length; i++)
            {
                keyArray[i] = keyTemp[i];
            }
            keyArray[keyArray.Length - 1] = key;
            

            for (int i = 0; i < valueTemp.Length; i++)
            {
                valueArray[i] = valueTemp[i];
            }
            valueArray[valueArray.Length - 1] = value;
        }


        public int Count
        {
            get { return keyArray.Length; }
        }

    }
}
