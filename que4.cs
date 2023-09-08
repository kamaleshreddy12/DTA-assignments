using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace assignmentq2
{
    internal class Program
    {
        private const int V = 1;
 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user id: ");
            string id = Console.ReadLine();
 
 
            Console.WriteLine("Enter password: ");
 
            ConsoleKeyInfo key;
            string pass = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter); // Stops Receving Keys Once Enter is Pressed
            //string pass = Console.ReadLine();
 
            string uid = "admin";
            string pwd = "admin123";
            string p = pass;
            // Console.WriteLine(pass == p);
 
            if (id == uid && p == pwd)
            {
                Console.WriteLine("Welcome to Admin");
            }
            else
            {
                Console.WriteLine("Invalid User Id or Password");
            }
}
