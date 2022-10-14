using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricAmount
{
    public static class Operations
    {
        static BillDetails currentBill=null;
        static List<BillDetails> billList=new List<BillDetails>();
        public static void MainMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice =="yes");
        }

        public static void Registration()
        {
    		System.Console.WriteLine("Enter your name : ");
			string userName = Console.ReadLine();
			System.Console.WriteLine("Enter your phone number : ");
			long phone = long.Parse(Console.ReadLine());
			System.Console.WriteLine("Enter the mail ID : ");
			string mail = Console.ReadLine();
			System.Console.WriteLine("Enter the amount of unit used : ");
			double unitUsed = double.Parse(Console.ReadLine());

			BillDetails customer = new BillDetails(userName,phone,mail,unitUsed);
			billList.Add(customer);
            System.Console.WriteLine("Your meter ID is "+ customer.MeterID);

        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Meter ID");
            string meterID = Console.ReadLine();
            foreach(BillDetails customer1 in billList )
            {
                if(customer1.MeterID == meterID)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentBill=customer1;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Wrong meter ID");
                }
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select 1.Show Details 2.Number Of Unit 3.Calculate Bill 4.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentBill.ShowDetail();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Number of Unit used");
                        currentBill.NumberOfUnit();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Calculate Bill");
                        currentBill.CalculateBill();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice = "no";
                        break;
                    }
                }
            } while (choice =="yes");
        }
    }
}