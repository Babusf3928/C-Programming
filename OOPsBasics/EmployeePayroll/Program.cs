using System;
using System.Collections.Generic;
namespace EmployeePayroll
{
    public enum WorkLocation{Default,Madura,Eymard}

    public enum Gender{Default,Male,Female,Transgender}

    class Program
    {
        public static void Main(string[] args)
        {
            Operations.MainMenu();
        }
    }
}