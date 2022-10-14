using System;
namespace HierarchicalEmployment;
class Program
{
    public static void Main(string[] args)
    {
         

         PersonalDetails person1=new PersonalDetails("Babu","Periyasamy",Gender.Male,9894007401);
         person1.ShowDetails();
         StudentDetails student1=new StudentDetails("526372","Babu","Periyasamy",Gender.Male,9894007401,Department.CSE,"Final");
         student1.ShowStudent();
         CustomerDetails customer1=new CustomerDetails("38467","Babu","Periyasamy",Gender.Male,9894007401);
         customer1.ShowCustomer();
         
         
        

        
    }
}