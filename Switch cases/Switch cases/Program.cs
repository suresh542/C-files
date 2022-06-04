using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_cases
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    {
                        Console.WriteLine("your are selected the zero files");
                        Cont
                    }
                case 1:
                    {
                        Console.WriteLine(" your are selected the one files");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("your are selected the two files");
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" default value are accepts");
                            break;
                    }
            }
            Console.ReadLine();
        }
    }
}
