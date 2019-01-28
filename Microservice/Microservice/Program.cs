using Microservice.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Menu ==================");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("=============================================");
            Console.Write("Going to : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=============================================");
            switch (choice)
            {
                case 1:
                    // ini untuk memangil menu Supplier Controller
                    SupplierController supplier = new SupplierController();
                    supplier.MenuSupplier();
                    break;
                default:
                    Console.Write("Please try again later");
                    break;
            }
        }
    }
}
