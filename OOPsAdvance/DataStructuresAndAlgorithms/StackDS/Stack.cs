using System;

namespace StackDS
{
    public partial class Stack<Type>
    {
        private Type [] Array { get; set; }
        private int _count;

        private int _capacity;

        public int Count { get {return _count;} }

        public Stack()
        {
            _count=0;
            _capacity=4;
            Array = new Type[_capacity];

        }

        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            Array = new Type[_capacity];
        }

        public void Push(Type data)
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
            Type [] Array2 = new Type[_capacity*2];
            for(int i=0;i<_count;i++)
            {
                Array2[i]=Array[i];
            }
            Array=Array2;
        }

        public Type Pop()
        {
            Type value=default(Type);
            if(_count<0)
            {
                System.Console.WriteLine("Empty Stack");
                
            }
            else if(_count>=0)
            {
                value = Array[_count];
                System.Console.WriteLine(Array[_count]);
                _count--;
            }
            return value;
            
        }

        public bool Contains(Type data)
        {
            bool value = false;
            for(int i =0;i<_count;i++)
            {
                if(data.Equals(Array[i]))
                {
                    value=true;
                }
                else
                {
                    value=false;
                }
            }
            return value;
        }

        public Type Peak()
        {
            return Array[_count];
        }
        
    }
}