using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMP_A01
{
    /*
     * This is a class used to represent a generic "device" of some sort.
     * The inherited members include the device name (deviceName), device
     * description (deviceDesc), among others.
    */
    class Device
    {
        //The operating system this device is using.
        private String  operatingSys;
        //The name of the device.
        private String  deviceName;
        //The description of the device.
        private String  deviceDesc;
        //The manufacturer of the device.
        private String  deviceManu;

        //The base clock speed of the central processing unit in the device.
        private double  clockSpeed;
        //The architecture of the processor; 32 or 64 bit.
        private int     arch;
        //The amount of memory the device has, measured in megabytes (Mb).
        private int     memory;
        //The amount of storage the device has, measured in gigabytes (Gb).
        private int     storage;            

        public Device()
        {
            //Initializing the string members.
            this.operatingSys = null;
            this.deviceName = null;
            this.deviceDesc = null;
            this.deviceManu = null;

            //Initializing the numeric members.
            this.clockSpeed = 0.0;
            this.arch = 0;
            this.memory = 0;
            this.storage = 0;
        }

        //This is a simple function to determine if a particular instance of a Device has
        //been initialized. deviceName is the only variable that can't be null if the Device
        //has been initialized, therefore it is called upon to determine the return value of
        //the function.
        public bool IsEmpty()
        {
            if (this.deviceName == null)
                return true;
            else
                return false;
        }

        /*
         * ==================
         * ACCESSOR FUNCTIONS
         * ==================
        */

        public String GetOS()
        {
            return this.operatingSys;
        }

        //This is a generic accessor function for the deviceName member of the Device class.
        public String GetName()
        {
            return this.deviceName;
        }

        //This is ageneric accessor function for the deviceDesc member of the Device class.
        public String GetDesc()
        {
            return this.deviceDesc;
        }

        public String GetManu()
        {
            return this.deviceManu;
        }

        public double GetClockSpeed()
        {
            return this.clockSpeed;
        }

        public int GetArchitecture()
        {
            return this.arch;
        }

        public int GetMemory()
        {
            return this.memory;
        }

        public int GetStorage()
        {
            return this.storage;
        }

        /*
         * =================
         * MUTATOR FUNCTIONS
         * =================
        */

        /*
         * All string member mutator functions check if the string passed to it is null.
         * If it is null, the value is not copied and the function returns false. If it
         * is not null, the value is assigned and true is returned.
        */
        public bool SetOperatingSystem(String os)
        {
            if (os == null)
                return false;
            else
            {
                this.operatingSys = os;
                return true;
            }
        }

        /*
         * This is a function that sets the deviceName value to whatever is passed
         * to it. It returns true if the assignment to the deviceName value is successfully
         * completed, otherwise it returns false.
        */
        public bool SetName(String n)
        {
            if (n == null)
                return false;
            else
            {
                this.deviceName = n;
                return true;
            }
        }

        /*
         * This is a function that sets the deviceDesc value to whatever is passed
         * to it. It returns true if the assignment to the deviceDesc value is successfully
         * completed, otherwise it returns false.
        */
        public bool SetDesc(String d)
        {
            if (d == null)
                return false;
            else
            {
                this.deviceDesc = d;
                return true;
            }
        }

        public bool SetManu(String m)
        {
            if (m == null)
                return false;
            else
            {
                this.deviceManu = m;
                return true;
            }
        }

        public bool SetClockSpeed(double cs)
        {
            if (cs < 0.0)
                return false;
            else
            {
                this.clockSpeed = cs;
                return true;
            }
        }

        public bool SetArchitecture(int s)
        {
            if (s != 32 && s != 64)
                return false;
            else
            {
                this.arch = s;
                return true;
            }
        }

        public bool SetMemory(int mem)
        {
            if (mem < 0)
                return false;
            else
            {
                this.memory = mem;
                return true;
            }
        }

        public bool SetStorage(int ns)
        {
            if (ns < 0)
                return false;
            else
            {
                this.storage = ns;
                return true;
            }
        }
    }
}
