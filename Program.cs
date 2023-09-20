using System;
using N_MathBasic;

namespace N_Main_Execute
{   
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
        
        static void Main(string []args){
            
          AskMath();
    
        }
    }
}
