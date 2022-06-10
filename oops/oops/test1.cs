using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class test1
    {
        public static int name = 0;
        int salary = 0;

        public void Display()
        {
            name += 1;
            salary += 1;
            Console.WriteLine("enter the id number : " + name);
            Console.WriteLine("salary : " + salary);
        }
    }
}
