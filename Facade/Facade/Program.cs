using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Method_A();
            facade.Method_B();
        }
    }
}
