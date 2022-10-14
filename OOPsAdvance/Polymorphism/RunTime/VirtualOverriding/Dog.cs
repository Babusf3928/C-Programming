using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverriding
{
    public class Dog:Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog Sound");
        }
    }
}