using System;
using FactoryDesingPatterns.classes;

namespace FactoryDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();

            IProduct product1 = c.FactoryMethod(ProductType.Product1 );
            Console.WriteLine(product1.siparisFormu());   
        }
    }
}
