using System;

namespace N_ApplyIndexes
{
    
    class ApplyIndexes{

        // first initial sample array
        public string[] strArr = new string[10];
        
        public string this[int index]{
    
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                    return strArr[index];
            }

            set
            {
                if (index < 0 ||  index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                strArr[index] = value;
            }
    
        }

       
    }

}