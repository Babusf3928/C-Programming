using System;
namespace String
{
    class Program
    {
        public static void Main(string[] args)
        {
            string splitword = "";
            Console.WriteLine("Enter the main string: ");
            string main = Console.ReadLine();
            Console.WriteLine("Enter the shorter string to search: ");
            string search = Console.ReadLine();
            string [] main1 = main.Split(search);
            foreach(string word in main1)
            {
                splitword += word;
            }
            Console.WriteLine("string searced count is: "+ splitword.Length);


        }
    }
}