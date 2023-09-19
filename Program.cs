using System;
using N_MathBasic;

namespace N_Main_Execute
{   
    class MainExecute{
        
        static void Main(string []args){
            
            // Access into method
            MathBasic cal = new MathBasic();

            Console.WriteLine("This is somthing");

            int num1 = 14;
            int num2 = 29;

            Console.WriteLine(cal.AddNum(num1, num2));      // 43
            Console.WriteLine(cal.MinusNum(num1, num2));    // -15
            Console.WriteLine(cal.MultiNum(num1, num2));    // 406
            Console.WriteLine(cal.DivNum(num1, num2));      // 0.4287....   

            // this is something to do 



        }
    }
}
