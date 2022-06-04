using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("this are the method and function");
            display();
            add(5, 4);
            add(12, 44);
            add(33, 33);
            add(99, 1);
            sub(33, 22);
            sub(22, 44);
            input();
            var x = vaule(11, 22, 33);
            Console.WriteLine("your vaule is : " + x);
            Console.ReadLine();
        }
        public static void display()
        {
            Console.WriteLine("dispaly the funtions!!!!");
        }
        public static void add(int a, int b)
        {
            Console.WriteLine("add the numbers = " + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("sub the number = " + (a - b));
        }
        public static void input()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value a = " + a);
    
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value a = " + a);

            Console.WriteLine("add the numbers = " + (a + b));
        }
        public static int vaule(int a, int b,int c)
        {
            return a + b - c;
        }
    }
}
