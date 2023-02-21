using System;

namespace DesginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new FactoryOld();
            factory.MadeCar();
        }
    }
}
