using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersize3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ex.3 / Познай паролата

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }

            // ex.4 / Еднакви думи

            Console.WriteLine("Write a your first word.");
            string firstword = Console.ReadLine();

            Console.WriteLine("Write a your second word.");
            string secondword = Console.ReadLine();

            if (firstword.ToLower() == secondword.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.Write("no");
            }
        }
    }
}
