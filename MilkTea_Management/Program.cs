using System;

namespace MilkTea_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt receipt = new Receipt();
            receipt.priceMilkTea();
            Console.ReadKey();
        }
    }
}
