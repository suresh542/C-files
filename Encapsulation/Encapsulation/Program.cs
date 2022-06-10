using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program : Class1
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Display();
            obj.Display1();
            obj.roll = 10;
            Console.WriteLine(obj.roll);
            Console.ReadLine();
        }
        public int roll
        {
            get; // getter 
            set; // setter     in using the Protection level....
        }
    }
}
