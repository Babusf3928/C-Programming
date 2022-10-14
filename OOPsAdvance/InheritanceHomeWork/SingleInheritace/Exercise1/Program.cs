using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("Babu","Periyasamy",9894007401,"babu20010704@gmail.com",new DateTime(2001,04,07),Gender.Male,"12th","CSE",2018);
        student1.ShowDetails();
    }
}