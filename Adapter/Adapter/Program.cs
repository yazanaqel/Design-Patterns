using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterIOSFromAndroid adapterIOSFromAndroid =
                new AdapterIOSFromAndroid(new AndroidCharger());

            adapterIOSFromAndroid.Charge();
        }
    }
}
