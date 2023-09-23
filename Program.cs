using System;
using N_MathBasic;
using N_VehicleFile;
using Interface_File;



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

    //Interface Class
    class File : IFile , ICreateNew{
        // Explicit Method
        // Prevent mix other interface with each other
        // With Interface, able to keep code DRY + handle each interface easily

        void IFile.ReadFile(){
            Console.WriteLine("Reading File in progress from IFile");
        }
         void IFile. AlterFile(){
            Console.WriteLine("You may alter file now , one from IFile ");
        }

        void ICreateNew. ReadFile(){
            Console.WriteLine("You may alter file now , one from ICreate ");
        }

        void ICreateNew. AlterFile(){
            Console.WriteLine("You may alter file now , one from ICreate  ");
        }
    
        // Standalone Method
        public void Search(string text)
        {
            Console.WriteLine(text);
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

        public static void AskSaveFile(){

            // Explicit Method , access resource saperately 
            File f1 = new File();
            IFile f2 = new File();
            ICreateNew f3 = new File();
           
           f2.ReadFile();
           f3.AlterFile();

            string? word2 = Console.ReadLine();
            f1.Search(word2);
        }
        static void Main(string []args){
            
          //AskMath();
          //AskVehicleCar();
          //MainExecute m1 =  new MainExecute();
          //m1.AskVehicleMotor();
          AskSaveFile();

        }
    }
}
