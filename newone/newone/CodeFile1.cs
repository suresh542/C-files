using System;

namespace myswitch
{
    public class newSwitch
    {
        public static void main(string[] args)
        {
            var Myinput = Convert.ToInt32(Console.ReadLine());
                switch(Myinput)
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
        }
    }
}