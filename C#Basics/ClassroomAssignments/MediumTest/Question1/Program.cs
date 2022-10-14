using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the basic salary amount per month:  ");
            double month = double.Parse(Console.ReadLine());
            if(month <=10000)
            {
                double amountOfDA1 = month*0.2;
                double amountOfHRA1 = month*0.8;
                double annualWithInterest1 = (month+amountOfDA1+amountOfHRA1)*12;
                double annualIncome1 = annualWithInterest1-(annualWithInterest1*0.07);
                System.Console.WriteLine("The Annual Gross Salary is "+annualWithInterest1+" his take home salary is "+annualIncome1);
            }
            else if(month >10000 && month <=20000)
            {
                double amountOfDA2 = month*0.25;
                double amountOfHRA2 = month*0.9;
                double annualWithInterest2 = (month+amountOfDA2+amountOfHRA2)*12;
                double annualIncome2 = annualWithInterest2-(annualWithInterest2*0.07);
                System.Console.WriteLine("The Annual Gross Salary is "+annualWithInterest2+" his take home salary is "+annualIncome2);

            }
            else if(month >20000)
            {
                double amountOfDA3 = month*0.3;
                double amountOfHRA3 = month*0.95;
                double annualWithInterest3 = (month+amountOfDA3+amountOfHRA3)*12;
                double annualIncome3 = (annualWithInterest3)-(annualWithInterest3*0.07);
                System.Console.WriteLine("The Annual Gross Salary is "+annualWithInterest3+" his take home salary is "+annualIncome3);
            }
        }
    }
}