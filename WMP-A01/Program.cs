using System;

namespace WMP_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone sixS = new Phone();
            sixS.SetName("iPhone 6S");
            sixS.SetManu("Apple");
            sixS.SetMemory(2048);
            sixS.SetOperatingSystem("iOS");
            sixS.SetClockSpeed(3.4);
            sixS.SetStorage(128);
            sixS.SetArchitecture(64);

            sixS.Display();
        }
    }
}
