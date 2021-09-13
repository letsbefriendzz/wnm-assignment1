using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMP_A01
{
    /*
     * This is a class that represents a generic cell phone. It extends the Device class,
     * thus many of its members.
    */ 
    class Phone : Device
    {
        //A 2 element array representing the dimensions of the screen on the phone.
        private double[]    screenSize;
        //A number that represents the megapixel count of the phone's onboard camera.
        private double      cameraMP;

        public Phone()
        {
            this.screenSize = new double[2];
            cameraMP = 0;
        }

        /*
         * ==================
         * ACCESSOR FUNCTIONS
         * ==================
        */

        public double[] GetScreenSize()
        {
            return this.screenSize;
        }

        public double GetCameraMP()
        {
            return this.cameraMP;
        }

        /*
         * =================
         * MUTATOR FUNCTIONS
         * =================
        */

        public bool SetScreenSize(double[] ss)
        {
            if (ss.Length > 2 || ss.Length == 0)
            {
                return false;
            }
            else
            {
                this.screenSize[0] = ss[0];
                this.screenSize[1] = ss[1];
                return true;
            }
        }

        public bool SetMP(double mp)
        {
            this.cameraMP = mp;
            return true;
        }

        public double CalcScreenSize()
        {
            return (this.screenSize[0] * this.screenSize[0]);
        }

        public void Display()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Name:\t\t" + this.GetName() + "\n");

            Console.WriteLine("=============================");
            Console.WriteLine("Desc:\t\t" + this.GetDesc() + "\n");

            Console.WriteLine("=============================");
            Console.WriteLine("Manufacturer:\t" + this.GetManu() + "\n");

            Console.WriteLine("=============================");
            Console.WriteLine("OS:\t\t" + this.GetOS() + "\n");

            Console.WriteLine("=============================");
            Console.WriteLine("CPU Speed:\t" + this.GetClockSpeed() + "\tGhz\n");

            Console.WriteLine("=============================");
            Console.WriteLine("Memory:\t\t" + this.GetMemory() + "\tMb\n");

            Console.WriteLine("=============================");
            Console.WriteLine("Storage:\t" + this.GetStorage() + "\tGb\n");

            Console.WriteLine("=============================");
            Console.WriteLine("Architecture:\t" + "x" + this.GetArchitecture() + "\n");
        }
    }
}
