using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Class2
    {
        public virtual void Display() // in base class only provide the Virtual class, override is not support to the base and super class
        {
            Console.WriteLine("Enter the Overriding here using for inheritance ");
        }
    }
}
