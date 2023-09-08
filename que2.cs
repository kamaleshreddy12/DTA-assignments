using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignmentq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userid = "Kamal123";
            string password = "kamal@123";

            string guserid = Console.ReadLine(Console.WriteLine("Enter user id: "));
            string gpassword = Console.ReadLine(Console.WriteLine("Enter password: "));

            if (userid == guserid && password == gpassword)
            {
                Console.WriteLine("valid details");
            }
            else
            {
                Console.WriteLine("Invalid details");
            }
            Console.ReadLine();
        }
    }
}
