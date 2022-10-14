using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
            bool temp = LinearSearch(key,out int index);
            return temp;
        }

        public bool ContainsValue(TValue value)
        {
            bool temp = false;
            for(int i=0;i<_count;i++)
            {
                if(value.Equals(Array[i].Value))
                {
                    temp = true;
                    break;
                }
                
            }
            return temp;
        }

        public KeyValue<TKey,TValue> ElementAt(int index)
        {
            KeyValue<TKey,TValue> output = null;
            for(int i = 0;i<_count;i++)
            {
                if(index.Equals(i))
                {
                    output = Array[i];
                    break;
                }
            }
            return output;
        }

        public void Remove(TKey key)
        {
            bool temp = LinearSearch(key, out int index);
            int flag = 0;
            for(int i = 0;i<_count;i++)
            {
                if(temp )
                {
                    Array[i] = Array[i+1];
                    flag++;
                }
                else if(flag==1)
                {
                    Array[i] = Array[i+1];
                }
                
            }
            _count--;
        }
    }
}