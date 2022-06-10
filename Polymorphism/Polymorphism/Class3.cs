using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Class3 : Class2
    {
        public override void Display() // override is only for assinged  inheritance after the provide override other wise not support 
        {
            Console.WriteLine("Enter the Overriding here using for hierarchical inheritance ");
        }
    }
}
