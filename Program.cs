using System;
using N_MathBasic;

namespace N_Main_Execute
{   
    class MainExecute{
        
        static void Main(string []args){
            
            // Access into method
            MathBasic cal = new MathBasic();

            //int num1 = 14;
            //int num2 = 29;

            //Console.WriteLine(cal.AddNum(num1, num2));      // 43
            //Console.WriteLine(cal.MinusNum(num1, num2));    // -15
            //Console.WriteLine(cal.MultiNum(num1, num2));    // 406
            //Console.WriteLine(cal.DivNum(num1, num2));      // 0.4287....   

            
            // Gather user input
            Console.Write("Input first digit :");
            double temp1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second digit :");
            double temp2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(" ") ;
            Console.WriteLine("Result of all Mathematics") ;
            Console.WriteLine(" ") ;
            Console.WriteLine(cal.AddNum(temp1, temp2));      
            Console.WriteLine(cal.MinusNum(temp1, temp2));    
            Console.WriteLine(cal.MultiNum(temp1, temp2));    
            Console.WriteLine(cal.DivNum(temp1, temp2));        
            Console.WriteLine(" ") ;
    
        }
    }
}
