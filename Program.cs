using System;
using N_MathBasic;
using N_VehicleFile; 
using Interface_File;
using PatialCompile;
using System.Security.Cryptography.X509Certificates;
using N_ApplyIndexes;
using System.Net;
using System.Runtime.InteropServices;
using CollectPrac;

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

    //Static class -> simple and easier to call/access
    static class Calculator{
        private static int num1 = 0;
        private static int num2 = 0;

      
        public static void DisInfo(){
            Console.WriteLine("First Digit  :" + num1);
            Console.WriteLine("Second Digit :" + num2);

            // Callback Method
            Console.WriteLine(Minus());
        }

        public static int Minus(){
            
            return num1 - num2;
        }

        public static void AskInfo(){
            Console.Write("Enter your first digit :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second digit :");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

    }

    // Generic class Method -> can be any type
    class ReferenceToUse<Type>{
        // declare field , In this case will be array
        private Type[] Student;
        private Type Email;

        public ReferenceToUse(){
            Student = new Type[10];
        }
        
        // Overload method
        public ReferenceToUse(int length){
            Student = new Type[length];
        }


        public Type this[int indexes]{
            get{
                // Error Handling 
                if(indexes < 0 || indexes > Student.Length){
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return Student[indexes];
            }
           
            set{
                // Error Handling 
                if(indexes < 0 || indexes > Student.Length){
                    throw new IndexOutOfRangeException("Index out of range");
                }

                Student[indexes] = value;
            }
        }

        // Display Total Length store in Array
        public int DisTotalElement(){
            return Student.Length;
        }

    }

    // Build a blueprint for class
    class StudentInfo<Type>{
        public Type Email    ;
        public Type Password ;
        
        // Constructor
        public StudentInfo(Type temp1, Type temp2){
            Email = temp1;
            Password = temp2;
        }


        public void ClarifyInfo(){
            string admin1 = "wenfung11211@gmail.com";
            string password = "121118Fk.";

            if(Convert.ToString(Email)  ==  admin1 && Convert.ToString(Password)  ==  password){
                Console.WriteLine("Welcome Admin");
                Console.WriteLine("");
            }else{
                Console.WriteLine("You are not the admin");
                Console.WriteLine("");
            }
        }

        public void ShowInfo(){
            Console.WriteLine(Email);
            Console.WriteLine(Password);
            ClarifyInfo();
        }
    }

    // Widely use in project
    class KeyValuePairDate<TKey, TValue>{
        public TKey KeyData     ;
        public TValue ValueData {get; set;}

        // Default Constructor
        public KeyValuePairDate(){}

        //Overlaod Constructor
        public KeyValuePairDate(TKey TempKey , TValue TempValue ){
            this.KeyData     = TempKey;
            this.ValueData   = TempValue;
        }
        
        // Practice Properties
        public TKey KeyDataInfo{
            get{ return this.KeyData;}
            set{ this.KeyData = value;}
        }

        public void ShowKeyValuePair(){
            Console.WriteLine(KeyData);
            Console.WriteLine("");
            Console.WriteLine(ValueData);
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
       
        public static void CheckPartialCompile(){
            Employee e1 = new Employee();

            Console.Write("Emplolyee Name :");
            e1.EpName = Console.ReadLine();

            Console.Write("Customer Name Handling:");
            e1.CustHandle = Console.ReadLine();

            e1.GetInfo();

            Console.WriteLine("Your new number will be :" + e1.EpNum);
            
            
        }

        public void AskGenericArray(){
            // Create Object with self-made data type 
            ReferenceToUse<int> m1 = new ReferenceToUse<int>();         // Class is integer variable, save multiple variable in array ()depends
            ReferenceToUse<string> s1 = new ReferenceToUse<string>(7);


            //string[] TeachName = new string[10];
        }








        static void Main(string []args){
            
          //AskMath();
          //AskVehicleCar();
          //MainExecute m1 =  new MainExecute();
          //m1.AskVehicleMotor();
          //AskSaveFile();

          //StudentInfo<string> st1 = new StudentInfo<string>("wenfung11211@gmail.com","121118Fk.");
          //st1.ShowInfo();

          //KeyValuePairDate<string , int> ky1 = new KeyValuePairDate<string, int>();
          //ky1.KeyDataInfo = "Frank";

          InitCollectPrac obj1 = new InitCollectPrac();
          obj1.AddSomething();
          obj1.AccessingItem();
          
        }
    }


}
