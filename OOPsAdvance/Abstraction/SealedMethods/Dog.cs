using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Dog:Animal
    {
        public new void MakeSound()
        {
            System.Console.WriteLine("Dog Sound");
        }
    }
}