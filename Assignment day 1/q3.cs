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
            string product_id = "";
            Console.WriteLine("Enter product id :");
            product_id = Console.ReadLine();

            string product_name = "";
            Console.WriteLine("Enter product name:");
            product_name = Console.ReadLine();

            int unit_price = 0;
            Console.WriteLine("Enter unit price :");
            unit_price = Convert.ToInt32(Console.ReadLine());

            int quantity = 0;
            Console.WriteLine("Enter quantity :");
            quantity = Convert.ToInt32(Console.ReadLine());



            int total_amount = unit_price * quantity;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Product Id: " + product_id);
            Console.WriteLine("Product name: " + product_name);
            Console.WriteLine("unit price: " + unit_price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total amount: " + total_amount);

            if (quantity < 10)
            {

                double val = 0.1;
                double discount_price = total_amount * val;
                discount_price = Convert.ToInt32(discount_price);
                Console.WriteLine("Discount ampount: " + discount_price);
                Console.WriteLine("Final amount: " + (total_amount - discount_price));

            }
            else if (quantity > 30 && quantity <= 50)
            {
                double val = 0.2;
                double discount_price = total_amount * val;
                discount_price = Convert.ToInt32(discount_price);
                Console.WriteLine("Discount ampount: " + discount_price);
                Console.WriteLine("Final amount: " + (total_amount - discount_price));

            }
            else if (quantity > 50)
            {
                double val = 0.3;
                double discount_price = total_amount * val;
                discount_price = Convert.ToInt32(discount_price);
                Console.WriteLine("Discount ampount: " + discount_price);
                Console.WriteLine("Final amount: " + (total_amount - discount_price));

            }





        
        }
    }
}