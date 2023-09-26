using System;


namespace PatialCompile
{
    // partial -> combine with same partial name class
    public partial class Employee{

        //Constructor
        public Employee(){
            //create random number when object call
            GenerateEmployeeId();
        }
         
        // properties
        public void GetInfo(){
            // output the field
            Console.WriteLine(EpName);
            Console.WriteLine(CustHandle);
            
        }

        partial void GenerateEmployeeId()
        {
            Random RandNum = new Random();
            EpNum = RandNum.Next(1,1000);
        }
    }
}