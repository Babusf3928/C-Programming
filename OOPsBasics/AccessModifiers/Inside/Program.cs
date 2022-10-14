using System;
namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First one = new First();
        System.Console.WriteLine(one.PublicNumber);         //public

       // System.Console.WriteLine(one.PrivateNumber);      //private
        System.Console.WriteLine(one.PrivateOutput);

        System.Console.WriteLine(one.InternalNumber);       //internal

        //System.Console.WriteLine(one.ProtectedNumber);      //protected
        Second two = new Second();
        System.Console.WriteLine(two.ProtectedOutput);

        System.Console.WriteLine(one.ProtectedInternalOutput);
    }
}