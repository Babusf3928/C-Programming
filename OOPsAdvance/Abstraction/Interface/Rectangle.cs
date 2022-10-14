using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRectangle
    {
        double Length { get; set; }
        double Breadth { get; set; }


        void GetValue(double length,double breadth);

        void CalculateArea();
    }
}