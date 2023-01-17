using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        Class1 class1;
        Class2 class2;
        Class3 class3;
        Class4 class4;

        public Facade()
        {
            class1 = new Class1();
            class2 = new Class2();
            class3 = new Class3();
            class4 = new Class4();
        }

        public void Method_A()
        {
            class1.Method1();
            class2.Method2();
        }
        public void Method_B()
        {
            class1.Method1();
            class2.Method2();
            class3.Method3();
            class4.Method4();
        }
    }
}