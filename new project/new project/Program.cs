using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    class Program
    {
        static void Main(string[] args)
        {

            var Myinput = Convert.ToInt32(Console.ReadLine());
            switch (Myinput)
            {
                case 0:
                    {
                        Console.WriteLine(" Enter the Zero case in the value");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Enter the one case ");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
