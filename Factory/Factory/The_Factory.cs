using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class The_Factory
    {
        public Interface1 Get_Class(String Obj)
        {
            if (Obj == "Rectangle")
            {
                return new Rectangle();
            }
            else if (Obj == "Squre")
            {
                return new Squre();
            }
            else
            {
                return new Circle();
            }
        }
    }
}
