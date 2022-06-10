using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_and_c
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] cars = { "9","6","2","3","7","4","8","1"};
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        } 
    }
}
