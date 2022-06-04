using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string rev = string.Empty;
           var user_input = Console.ReadLine();
           /*user_input = user_input.ToLower();*/
           for (int i=user_input.Length-1;i>=0;i-- )
            {
                rev = rev + user_input[i];
            }
            Console.WriteLine("value are : {0}",rev);
            Console.ReadLine();
        }
    }
}
