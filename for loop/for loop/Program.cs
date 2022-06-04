using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for(var i=0;i<5;i++)
                  {
                  Console.WriteLine("Hello World!!!!");
              }
              var input =Console.ReadLine();
              Console.WriteLine("Your name is : " + input);
              Console.ReadLine();*/

            int i = 0;
            do
            {
                Console.WriteLine("Hello World!!!!");
                i++;
            } while (i < 5);
            Console.ReadLine();

        }
    }
}
