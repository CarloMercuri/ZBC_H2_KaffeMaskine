using System;

namespace ZBC_H2_KaffeMaskineD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            factory.CreateMoccaMasterCoffeeMachine();

            Console.ReadKey();
        }
    }
}
