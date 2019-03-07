using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        private static string userName, password, password2;
        private static long phoneNo;


        static void Main(string[] args)
        {

            userRegistration();

        }


















        static void userRegistration()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\2640\source\repos\PhoneBook_Project\accounts.txt");

            Console.WriteLine("Enter your username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Confirm your password: ");
            password2 = Console.ReadLine();
            Console.WriteLine("Enter your phone number: ");
            phoneNo = Convert.ToInt64(Console.ReadLine());

            if (password == password2)
            {
                sw.WriteLine("{0}|{1}|{2}", userName, password, phoneNo);
                Console.WriteLine("Phone Book created successfully");
                sw.Close();
            }
            else
            {
                Console.WriteLine("Your password does not match.");
            }

        }


    }
}
