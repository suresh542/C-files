using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(var i=0;i<10;i++)
            {
                
                if (i==8)
                {
                    continue;
                }
                Console.WriteLine("Hello World!!!"+" "+i);
            }
            Console.ReadLine();
        }
    }
}
