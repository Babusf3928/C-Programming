using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public double Area { get; set; }

        public double Length { get; set; }
        public double Breadth { get; set; }

        public void GetValue(double length,double breadth)
        {
            Length=length;
            Breadth=breadth;
        }

    

        public void CalculateArea()
        {
            Area=Length*Breadth;
            System.Console.WriteLine($"Area of Rectangle : {Area}");
        }
        
    }
}