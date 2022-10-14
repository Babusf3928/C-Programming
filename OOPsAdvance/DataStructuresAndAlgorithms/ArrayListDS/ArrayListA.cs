using System;

namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void Insert(int index,dynamic data)
        {
            _count+=1;
            _capacity+=1;
            dynamic [] Array3 = new dynamic[_capacity];
            for(int i = 0;i<_count+1;i++)
            {
                if(i==index)
                {
                    Array3[i]=data;
                }
                else if(i<index)
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
            for(int i = 0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i] = Array[i+1];
                }
            }
            _count--;
        }

        public void Remove(dynamic data)
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

        public void IndexOf(dynamic data)
        {
            for(int i = 0;i<_count;i++)
            {
                if(data.Equals(Array[i]))
                {
                    System.Console.WriteLine("The index of "+data+" is "+i);
                }
            }
        }


    }
}