using System;

namespace N_VehicleFile
{
    abstract class VehicleType
    {   
        
        public string VehicleM = "";
        public string VehicleC = "";
        public double VehicleP = 0.0;

        // Properties
        public string VehicleModel{ 
            get { return VehicleM; }
            set { VehicleM = value; }
        }

        public string VehicleColor{ 
             get { return VehicleC; }
            set { VehicleC = value; }
        }

        public double VehiclePrice{ 
             get { return VehicleP; }
            set { VehicleP = value; }
        }

        //Override Method
        public abstract void VehicleSpeak();

        public void ShutDown(){
            Console.WriteLine("Vehicle is shutting down now");
        }

    }
}