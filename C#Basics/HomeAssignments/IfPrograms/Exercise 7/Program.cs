using System;
namespace Exercise7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Customer ID: ");
            double customer = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the amount of unit used: ");
            double unitUsed = double.Parse(Console.ReadLine());
            double unit = unitUsed;
            if(unitUsed > 0 && unitUsed <= 199)
            {
                unit *=(1.20);
            }
            else if (unitUsed >=200 && unitUsed <400)
            {
                unit *=(1.50);
            }
            else if(unitUsed >=400 && unitUsed <600)
            {
                unit *=(1.80);
            }
            else if(unitUsed >=600 )
            {
                unit *=(2.00);
            }
            double unitAmount = unit;
            double surchangeAmount = 0;
            if(unitAmount >400)
            {
                surchangeAmount = unitAmount * (0.15);
            }
            double totalAmount = unitAmount+surchangeAmount;
            Console.WriteLine("Customer IDNO :"+customer+ "\nCustomer Name :"+name+ "\nunit Consumed :"+unitUsed+"\nunit : "+unit+ "\nSurchange Amount : "+surchangeAmount+ "\nNet Amount Paid By the Customer : "+totalAmount);
            
        }
    }
}