using System;

namespace Singleton
{
    class Client
    {
        static void Main(string[] args)
        {
            var instance1 = Singleton_V2.GetInstance();
            var instance2 = Singleton_V2.GetInstance();

            Console.WriteLine(instance1 == instance2);
            Console.ReadKey();
        }
    }
}
