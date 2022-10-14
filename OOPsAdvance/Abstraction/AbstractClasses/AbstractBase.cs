using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        protected string name;         //Normal field
        public abstract string Name { get; set; }          //Abstract property
        public double Amount { get; set; }          
        public void Display()                   
        {
            System.Console.WriteLine(name);
        }

        public abstract void Salary(int days);     //Abstract Method

    }
}