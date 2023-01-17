using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class IOSCharger : IOS
    {
        public void Charge()
        {
            Console.WriteLine("IOS Charger");
        }
    }
}