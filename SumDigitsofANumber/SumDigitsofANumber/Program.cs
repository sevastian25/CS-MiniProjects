using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsofANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            Console.Write("Please enter an integer: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int n = num; n > 0; sum += n % 10, n /= 10);

            Console.WriteLine("The sum of your integer's didits is {0}", sum);



        }
    }
}
