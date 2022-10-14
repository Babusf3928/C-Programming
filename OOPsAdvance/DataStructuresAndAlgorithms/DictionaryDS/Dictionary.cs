using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        
        private int _count =0;

        private int _capacity =0;
        public int Count { get{return _count;} }
        
        public int Capacity { get{return _capacity;} }

        public KeyValue<TKey,TValue> [] Array { get; set; }

        public TValue this [TKey key]
        {
            get
            {
                TValue output = default(TValue);
                int index = 0;
                bool temp = LinearSearch(key, out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Key");
                }
                return output;
            }
            set
            {
                int position = 0;
                bool temp = LinearSearch(key, out position);
                if(temp)
                {
                    Array[position].Value=value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Key");
                }
            }
        }
    

        public Dictionary()
        {
            _count=0;
            _capacity=4;
            Array = new KeyValue<TKey,TValue>[_capacity];
        }

        public Dictionary(int size)
        {
            _count=0;
            _capacity=size;
            Array = new KeyValue<TKey,TValue>[_capacity];
        }

        public void Add(TKey key,TValue value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            bool temp = LinearSearch(key,out int index);
            if(temp == true)
            {
                System.Console.WriteLine("Duplicate Key");
            }
            else if(temp == false)
            {
                KeyValue<TKey,TValue> data = new KeyValue<TKey, TValue>();
                data.Key = key;
                data.Value = value;
                Array[_count] = data;
                _count++;
            }
            

        }

        public void GrowSize()
        {
            _capacity*=2;
            KeyValue<TKey,TValue> [] Array2 = new KeyValue<TKey, TValue>[_capacity];
            for(int i = 0;i<_count;i++)
            {
                Array2[i]=Array[i];
            }

            Array = Array2;
        }

        public bool LinearSearch(TKey key, out int index)
        {
            bool value = false;
            index = 0;
            for(int i = 0;i<_count;i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    value = true;
                    break;
                }
                else
                {
                    value = false;
                }
            }
            return value;
                
            
        }


    }
}