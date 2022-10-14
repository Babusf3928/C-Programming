using System;
namespace Exercise10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Password: ");
            string password = Console.ReadLine();
            if(password == "HiTeam")
            {
                Console.WriteLine("Right password");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}