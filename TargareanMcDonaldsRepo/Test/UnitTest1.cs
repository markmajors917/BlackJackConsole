using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Classes
{
       class Person
       {
       public Person()
       {
        
        
       }
        private int _age;
        
        
       public int Age
        {
            get { return _age; }
            set
            {
                //  Check if the age is reralistic (between 0 and 122)
                if (value >= 0 && value <= 122)
                {
                    _age = value;
                }
            }
       }
            public bool IsAtLeast21 { get
            {
                // (condition) ? C# if true : C# if false
                return (Age > 20) ? true : false;
            }  
           
       }
    
       
       
    
    
}
