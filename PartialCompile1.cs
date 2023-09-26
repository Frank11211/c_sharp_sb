using System;

namespace PatialCompile
{
    // partial -> combine with same partial name class
    public partial class Employee{
         
        // properties
        public string EpName {get; set;}
        public string CustHandle {get;set;}

        public int EpNum {get; set;}

        // override method i guess, with partial 
        partial void GenerateEmployeeId();


    }
}