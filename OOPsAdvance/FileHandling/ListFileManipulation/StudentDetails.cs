using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFileManipulation
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        
    }
}