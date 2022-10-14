using System;

namespace StudentAdmission
{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        {
            Type [] Array3 = new Type[_capacity+1];
            for(int i = 0;i<_count+1;i++)
            {
                if(i==index)
                {
                    Array3[i]=data;
                }
                if(i<index)
                {
                    Array3[i]=Array[i];
                }
                else if(i>index)
                {
                    Array3[i] = Array[i-1];
                }
            }
            Array=Array3;
            _count++;
        }

        public void RemoveAt(int index)
        {
            for(int i = 0;i<_count-2;i++)
            {
                if(i>=index)
                {
                    Array[i] = Array[i+1];
                }
            }
            _count--;
        }

        public void Remove(Type data)
        {
            for(int i=0;i<_count;i++)
            {
                if(data.Equals(Array[i]))
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
        }


    }
}