using System ;

namespace Interface_File
{
    // default as public 
    // property , method available 

    interface IFile{
        
        // Method to be override
        void ReadFile();
        void AlterFile();
    
    }


    interface ICreateNew{
        void ReadFile();
        void AlterFile();
    }   
}