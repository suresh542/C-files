using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class2 com = new Class1();
            com.Display();
            Class2 vo = new Class3();
            vo.Display();
            Console.ReadLine();
        }

    }
}
