using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            The_Factory F1 = new The_Factory();
            F1.Get_Class("Rectangle").print();
            F1.Get_Class("Squre").print();
            F1.Get_Class("Circle").print();
        }
    }
}
