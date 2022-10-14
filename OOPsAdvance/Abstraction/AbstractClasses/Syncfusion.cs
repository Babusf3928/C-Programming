using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Syncfusion:AbstractBase
    {
        public override string Name { get{return name;} set{name=value;} }

        public override void Salary(int days)
        {
            Display();
            Amount=(double)days*500;
            System.Console.WriteLine("The Salary Amount is "+Amount);

        }
    }
}