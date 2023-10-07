using System;
using System.Collections;
using System.Globalization;


namespace CollectPrac
{
    

    class InitCollectPrac{
        ArrayList al1 = new ArrayList();
        public void AddSomething(){

            // no data type limit, duplicate and null value is available 
            
            al1.Add("This is a string");
            al1.Add(123123);
            al1.Add(55+50);
            al1.Add(true);

            // Another Method
            ArrayList al2 = new ArrayList()
            { 2, "Steve", " ", true, 4.5, null };

        }

        public void AccessingItem(){
            // Accessing ArrayList
            // Depends on Array item 
            int getString = (int) al1[2]; // 123123 -> string
            int getString2 = (int) al1[1]; // 105 -> string

            // OR

            //using var keyword without explicit casting
            var firstElement = al1[3]; //returns 1
            var secondElement = al1[0]; //returns "Bill"

            Console.WriteLine(getString.GetType());
            Console.WriteLine(getString2.GetType());

        }


    }




}