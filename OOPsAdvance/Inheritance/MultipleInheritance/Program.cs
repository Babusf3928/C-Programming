using System;
namespace MultipleInheritance;
class Program
{
    public static void Main(string[] args)
    {
         

         PersonalDetails person1=new PersonalDetails("Babu","Periyasamy",Gender.Male,9894007401);
         person1.ShowDetails();
         StudentDetails student1=new StudentDetails("526372","Babu","Periyasamy",Gender.Male,9894007401,Department.CSE,"Final");
         student1.ShowStudent();
         student1.GetMark(85,91,90);
         student1.Calculate();
         student1.ShowMark();
         CustomerDetails customer1=new CustomerDetails("38467","Babu","Periyasamy",Gender.Male,9894007401);
         customer1.ShowCustomer();
         
         
        

        
    }
}