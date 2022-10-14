using System;
namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            string [] names = new string[size];
            int i;
            for( i = 0;i < size; i++)
            {
                Console.WriteLine("Enter the name: ");
                names[i]= Console.ReadLine();
            }
            for(i = 0; i < size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Enter the name to search");
            string searchName = Console.ReadLine();
            int temp = 0;
            for(i=0;i < size; i++)
            {
                if(names[i] == searchName)
                {
                    Console.WriteLine("The name is present in the array ");
                    Console.WriteLine("The index value of the name is  "+ i );
                    temp = 1;
                }
            }
            if(temp==0)
            {
                Console.WriteLine("The name is not present in the array");
            } 
            foreach(string name in names)
            {
                if(name == searchName)
                {
                    Console.WriteLine("The name is present in the array ");
                    temp = 1;
                }
            }
            if(temp==0)
            {
                Console.WriteLine("The name is not present in the array");
            } 


        }
    }
}