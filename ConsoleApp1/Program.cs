using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Program.XO(Console.ReadLine()));
            Console.ReadLine();

        }
        public static bool XO(string input)
        {
            bool x = true;
            bool o = true;
            for(int i=0; i<input.Length ;i++)
            {
                switch (input[i])
                {
                    case 'o':
                    case 'O':
                        o = !o;
                        Console.WriteLine("1o");
                        break;
                    case 'x':
                    case 'X':
                        x = !x;
                        Console.WriteLine("1x");
                        break;
                }
            }
            if (x == true && o == true)
                return true;
            else
                return false;
        }
    }
}
