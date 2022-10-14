using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee1 = new EmployeeInfo(new DateTime(2022,10,05),8,20000,"September","Babu","Periyasamy",Gender.Male,9894007401,new DateTime(2001,04,07),"Chemical");
        employee1.ShowEmployee();
    }
}