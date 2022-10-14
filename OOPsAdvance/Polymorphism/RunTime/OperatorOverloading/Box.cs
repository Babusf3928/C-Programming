using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Box
    {
        private double length;

        private double breadth;

        private double height;

        public Box(double length1,double breadth1,double height1)
        {
            length=length1;
            breadth=breadth1;
            height=height1;
        }  

        public Box()
        {
            length=0;
            breadth=0;
            height=0;
        } 

        public double GetVolume()
        {
            return length*breadth*height;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box();
            box.length = box1.length + box2.length;
            box.breadth = box1.breadth + box2.breadth;
            box.height  = box1.height + box2.height;
            return box;
        }
    }
}