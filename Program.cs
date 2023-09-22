using System;
using N_MathBasic;
using N_VehicleFile;

namespace N_Main_Execute
{    
    // VehicleFile -> Base Abstract Class
    class Car : VehicleType {
       public override void VehicleSpeak(){
            Console.WriteLine("This car is going to Pi Pi PIIIIIIII mother fucker");
       } 
    }

    class Motor : VehicleType {
        public override void VehicleSpeak(){
            Console.WriteLine("This Motor is going to VROMMMMM mother fucker");
       } 
    }

    class MainExecute{
        
        // static -> call method without create object.
        public static void AskMath(){

            // Access into method
            MathBasic cal = new MathBasic();
            
            // Gather user input
            Console.Write("Input first digit : ");
            cal.Temp1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second digit : ");
            cal.Temp2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Percentage if needed : ");
            cal.Temp_Percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ") ;
            Console.WriteLine("Result of all Mathematics") ;
            Console.WriteLine(" ") ;
            Console.WriteLine("First Digit :" + cal.Temp1);
            Console.WriteLine("Second Digit :" + cal.Temp2);
            Console.WriteLine(" ") ;
            Console.WriteLine("The result for Add       : "+ cal.AddNum(cal.Temp1, cal.Temp2));      
            Console.WriteLine("The result for Subtract  : "+ cal.MinusNum(cal.Temp1, cal.Temp2));    
            Console.WriteLine("The result for Multiply  : "+ cal.MultiNum(cal.Temp1, cal.Temp2));    
            Console.WriteLine("The result for Divide    : "+ cal.DivNum(cal.Temp1, cal.Temp2));         
            Console.WriteLine(" ") ;
            Console.WriteLine("Percentage you set is    : "+ cal.Temp_Percent +" %");
            Console.WriteLine("After percentage is      : "+ cal.ConvertPercentToNum(cal.AddNum(cal.Temp1, cal.Temp2), cal.Temp_Percent));
            
        }
        
        public static void AskVehicleCar(){
            Car car1 = new Car();

            Console.Write("Input your car Model: ");
            car1.VehicleModel = Console.ReadLine();
    
            Console.Write("The model color for car: ");
            car1.VehicleColor = Console.ReadLine();

            Console.Write("Border Price to be sell: ");
            car1.VehiclePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine(" Car Model : " + car1.VehicleModel);
            Console.WriteLine(" Car Color : " + car1.VehicleColor);
            Console.WriteLine(" Car Type  : " + car1.VehiclePrice);

            Console.WriteLine(" ");
        }

        public void AskVehicleMotor(){

            Motor m1 = new Motor();
            Console.Write("Input your motor Model: ");
            m1.VehicleModel = Console.ReadLine();
    
            Console.Write("The model color for motor: ");
            m1.VehicleColor = Console.ReadLine();

            Console.Write("Border Price to be sell: ");
            m1.VehiclePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine(" Motor Model : " + m1.VehicleModel);
            Console.WriteLine(" Motor Color : " + m1.VehicleColor);
            Console.WriteLine(" Motor Type  : " + m1.VehiclePrice);

            Console.WriteLine(" ");

            m1.VehicleSpeak();
            m1.ShutDown();

            Console.WriteLine(" ");
        }

        static void Main(string []args){
            
          //AskMath();
          //AskVehicleCar();
           MainExecute m1 =  new MainExecute();
           m1.AskVehicleMotor();
        }
    }
}
