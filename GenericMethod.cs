using System;

namespace N_GenericMethod
{

    public delegate void MyDelegate(string temp1);
    
    class DataMethod<Type, TKey, TValue>{
        private Type Data;
        private Type[] Data2 = new Type[10];
        private TKey VKey {get; set;}
        private TValue VValue {get; set;}


        public DataMethod(){}

        public DataMethod(TKey temp1, TValue temp2){
            this.VKey = temp1;
            this.VValue = temp2;
        }

        // Return Data type
        public TValue GetDataByKey(TKey temp3){
            if(temp3.ToString == VKey.ToString){
                return this.VValue;
            }
            else
            {
                // Add a return statement to handle the case when the condition is not satisfied.
                return default(TValue); // or return something else if appropriate
            }
        }
    }
}