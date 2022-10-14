using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the basic salary amount per month:  ");
            double month = double.Parse(Console.ReadLine());
            double amountOfDA = month*(0.10);
            double amountOfHRA = month*(0.10);
            double annualWithinterest = (month+amountOfDA+amountOfHRA)*12;
            double annualIncome = annualWithinterest-(annualWithinterest*0.05);
            System.Console.WriteLine("The person's annual income is "+annualIncome);
        }
    }
}