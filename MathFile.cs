using System;

namespace N_MathBasic
{
    class MathBasic{
        
        // Field
        public double temp1 = 0;
        public double temp2 = 0;
        

        // Properties
         public double Temp1 {
            get { return temp1;}
            set { temp1 = value;}
        }
          public double Temp2 {
            get { return temp2;}
            set { temp2 = value;}
        }

git
        // Converter
        public MathBasic( double input1 = 0.0, double input2 = 0.0){
            temp1 = input1 ; // 0.0 as default value
            temp2 = input2 ; // 0.0 as default value
        }

        // Function
        // Add
        public int AddNum(int temp1 , int temp2 ){
            return temp1 + temp2 ;
        }

        // Overriding AddNum function
         public double AddNum(double temp1 , double temp2 ){
            return temp1 + temp2 ;
        }



        // Minus
        public int MinusNum(int temp1 , int temp2 ){
            return temp1 - temp2 ;
        }

        // Overriding MinusNum function
         public double MinusNum(double temp1 , double temp2 ){
            return temp1 - temp2 ;
        }



        public int MultiNum(int temp1 , int temp2 ){
            return temp1 * temp2 ;
        }

        // Overriding MinusNum function
         public double MultiNum(double temp1 , double temp2 ){
            return temp1 * temp2 ;
        }



        public int DivNum(int temp1 , int temp2 ){
            return temp1 / temp2 ;
        }

        // Overriding MinusNum function
         public double DivNum(double temp1 , double temp2 ){
            return temp1 / temp2 ;
        }



        // Check Remainder 
        public bool ReminderNum(int temp1 , int temp2 ){
            // 2 / 2 = 1 -> return true as no reminder
            return (temp1 % temp2) != 0;
        }

         public bool ReminderNum(double temp1 , double temp2 ){
            return (temp1 % temp2) != 0;
        }


        // Minus Percentage
        public double ConvertPercentToNum(int value1 = 0 ,int temp_percent = 0){
            return (temp_percent / 100) * value1 ;
        }

    }
}