using System;

namespace N_MathBasic
{
    class MathBasic{

        // TODO 
        // function -> Add / Subtract / Multiply / Divide
        
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


    }
}