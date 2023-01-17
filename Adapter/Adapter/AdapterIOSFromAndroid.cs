using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterIOSFromAndroid : IOS
    {
        private AndroidCharger androidCharger;
        public AdapterIOSFromAndroid(AndroidCharger androidCharger)
        {
            this.androidCharger = androidCharger;
        }
        public void Charge()
        {
            androidCharger.Charge();
        }
    }
}