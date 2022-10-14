using System;

namespace ArrayListDS
{
    public partial class ArrayList
    {
        private dynamic [] Array {get;set;}
        private int _count;
        private int _capacity; 
        public int Count { get{return _count;}}
        public int Capacity { get{return _capacity;}}

        public dynamic this[int i]{get{return Array[i];} set{Array[i]=value;}}

        public ArrayList()
        {
            _count = 0;
            _capacity = 4;
            Array = new dynamic[_capacity];
        }

        public ArrayList(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new dynamic[_capacity];
        }

        public void AddElement(dynamic data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count] = data;
            _count++;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            dynamic[] Array2 = new dynamic[_capacity];
            for(int i = 0;i<Array.Length;i++)
            {
                Array2 [i]= Array[i];
            }
            Array=Array2;
            
        }    
    }
}