using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLINQ
{
    public class Student
    {
        
        public int StudentID { get; set; }  
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Role { get; set; }
        


        public override string ToString()
        {
           string output =  $"{this.FirstName} {this.LastName}";
           return output;
            
        }

    }
}