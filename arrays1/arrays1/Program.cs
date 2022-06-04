using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] name = new string[5];
              name[0] = "ajith";
              name[1] = "vjay";
              name[2] = "sk";
              name[3] = "rajini";
              name[4] = "kamal";
              for (var i = 0; i< name.Length; i++)
                  {
                  Console.WriteLine("Tamil cinema starts are = " + name[i]);
                  }
              Console.ReadLine();*/
            string[,] name = new string[3, 4];
            name[0, 0] = "mango";
            name[0, 1] = "orange";
            name[0, 2] = "pinaple";
            name[0, 3] = "graps";
            name[1, 0] = "barry";
            name[1, 1] = "lemon";
            name[1, 2] = "papiya";
            name[1, 3] = "banana";
            name[2, 0] = "watermilan";
            name[2, 1] = "sapota";
            name[2, 2] = "apple";
            name[2, 3] = "pie";
            /*for(var i = 0; i<name.Length;i++)
                for (var w = 0; w<name.Length;w++)
                   {
                        Console.WriteLine("available iteam in this market : " + name[i,w]);
                   }
            Console.ReadLine();*/
            Console.WriteLine(name[0, 2]);
            Console.ReadLine();        }
    }
}
