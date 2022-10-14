using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricAmount
{
    public class BillDetails
    {
        private static int s_meterID = 1000;
        public string MeterID { get;}
        
        public string UserName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public double UnitUsed { get; set; }
        
        public BillDetails(string username,long phone,string mail,double unitUsed)
        {
            s_meterID++;
            MeterID = "EB"+s_meterID;
            UserName=username;
            Phone=phone;
            Mail=mail;
            UnitUsed=unitUsed;
        }

        public void ShowDetail()
        {
            System.Console.WriteLine("Bill Detail :");
            System.Console.WriteLine($"Customer name is {UserName} \nCustomer phone number is {Phone} \nCustomer mail ID is {Mail} \nUnits used by a cutomer is {UnitUsed}");
        }

        public void NumberOfUnit()
        {
            System.Console.WriteLine("The Number of unit used is "+UnitUsed+" units");
        }

        public void CalculateBill()
        {
            if(UnitUsed<=100)
            {
                System.Console.WriteLine("No bill has to be paid");
            }
            else if(UnitUsed>100 && UnitUsed<=200)
            {
                System.Console.WriteLine("The bill amount is "+((UnitUsed-100)*3)+" Rupees");
            }
            else if(UnitUsed>200 && UnitUsed<=400)
            {
                System.Console.WriteLine("The bill amount is "+((100*3)+((UnitUsed-200)*5))+" Rupees");
            }
            else if(UnitUsed>400)
            {
                System.Console.WriteLine("The bill amount is "+((100*3)+(200*5)+((UnitUsed-400)*6))+" Rupees");
            }
        }

        

    }
}