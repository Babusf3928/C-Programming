using System;
namespace Enumerated
{
    public enum Gender {Default,Male,Female,Transgender}
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Select Gender Options Male,Female,Transgender");
            Gender gender1 = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine(gender1);

            System.Console.WriteLine("Select Gender Options Male,Female,Transgender");
            Gender gender2 = Gender.Default;
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
            while(!temp || !((int)gender2<4 && (int)gender2>0))
            {
                System.Console.WriteLine("Invalid gender \nEnter again");
                temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
            } 
            System.Console.WriteLine(gender2);
        }
    }
}