using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverriding
{
    public class Puppy:Dog
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Puppy Sound");
        }
    }
}