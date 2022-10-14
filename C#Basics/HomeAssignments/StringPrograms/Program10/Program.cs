using System;
namespace Program10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the username : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Input the password : ");
            string password = Console.ReadLine();
            if(name == "user" && password == "pass")
            {
                System.Console.WriteLine("Password entered successfully!");
            }
            else
            {
                System.Console.WriteLine("Wrong Password");
            } 
        }
    }
}