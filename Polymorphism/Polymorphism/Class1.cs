using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Class1 : Class2
    {
        public override void Display() // 1 class
        {
            Console.WriteLine("Enter the base Class in the overriding : ");
        }
        public void Display(int a, int b)// 2 class
        {
            Console.WriteLine("added the value : " + (a + b));
        }
        public void Display(String a, int b)// 2 class
        {
            Console.WriteLine("added the value : " + (a + b));
        }
        public void Display(int a, string b)// 3 class
        {
            Console.WriteLine("added the value : " + (a + b));
        }
    }
}
