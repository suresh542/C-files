using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anothercount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your variables here : ");
            var count = Console.ReadLine();
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            foreach(var character in count)
            {
                if (character != ' ')
                {
                    if(!charcount.ContainsKey(character))
                    {
                        charcount.Add(character, 1);
                    }
                    else
                    {
                        charcount[character]++;
                    }
                }
            }
            foreach(var character in charcount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character .Value);
            }
            Console.ReadLine();
        }
    }
}
