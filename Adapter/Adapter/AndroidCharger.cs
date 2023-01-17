using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AndroidCharger : Android
    {
        public void Charge()
        {
            Console.WriteLine("Android Charger");
        }
    }
}