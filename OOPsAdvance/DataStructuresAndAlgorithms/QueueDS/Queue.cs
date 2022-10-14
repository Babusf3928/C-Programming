using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public class Queue<Type>
    {
        private Type [] Array;
        private int _count;
        public int Count { get {return _count;} } 
        private int _head;
        private int _capacity;
        private int _tail;

        public Queue()
        {
            _count=0;
            _head=0;
            _capacity=4;
            _tail=0;
            Array = new Type[_capacity];
        }

        public Queue(int size)
        {
            _count=0;
            _head=0;
            _capacity=size;
            _tail=0;
            Array = new Type[_capacity];
        }

        public void Enqueue(Type data)
        {
            if(-_tail==_capacity)
            {
                GrowSize();
            }
            
            Array[_tail]=data;
            _tail++;
            _count++;
            
        }

        public void GrowSize()
        {
            Type [] Array2 = new Type[_capacity*2];
            for(int i = 0;i<_tail;i++)
            {
                Array2[i]=Array[i];
            }
            Array=Array2;
        }

        public Type  Dequeue()
        {
            Type value = default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty Queue");
            }
            else
            {
                value=Array[_head];
                _head++;
                _count--;
            }
            return value;
        }
        public Type Peak()
        {
            Type value = default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty Queue");
            }
            else
            {
                value=Array[_head];
                
            }
            return value;
        }

        public bool Contains(Type data)
        {
            bool value = false;
            for(int i = 0;i<_tail;i++)
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

    }
}