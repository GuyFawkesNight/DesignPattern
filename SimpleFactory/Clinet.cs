using SimpleFactory.Product;
using SimpleFactory.SimpleFactory;
using System;

namespace SimpleFactory
{
    class Clinet
    {
        static void Main(string[] args)
        {
            //IProduct p = SimpleFactory_V1.CreateInstance("ProductA");

            //IProduct p = SimpleFactory_V2.CreateInstance(ProductTypeEnum.ProductB);

            IProduct p = SimpleFactory_V3.CreateInstance();
            Console.WriteLine(p.Description());

            Console.ReadKey();
        }
    }
}
