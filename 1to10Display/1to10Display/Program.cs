using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1to10Display
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Do Loop");
            while(i != 11)
            {
                Console.WriteLine(i++);
                Thread.Sleep(200);
            }

            int j = 1;
            Console.WriteLine("Do While Loop");
            do
            {
                Console.WriteLine(j++);
                Thread.Sleep(200);
            }while (j != 11) ;
        }
    }
}
