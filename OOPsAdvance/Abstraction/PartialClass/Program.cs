using System;
namespace PartialClass;
class Program
{
    public static void Main(string[] args)
    {
        StudentDetails student1 = new StudentDetails("Babu","Periyasamy",DateTime.Now,Gender.Male,90,90,90);
        student1.ShowDetails();
    }
}