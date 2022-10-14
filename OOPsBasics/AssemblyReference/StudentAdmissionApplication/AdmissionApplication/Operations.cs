using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissonApplication
{
  
    public class Operations
    {
        public static void MainMenu()
        {
            List<StudentDetail> studentList=new List<StudentDetail>();
            string willing = "";

            do
            {

                System.Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter your father's name : ");
                string fatherName = Console.ReadLine();
                System.Console.WriteLine("Enter your date of birth in dd/MM/yyyy : ");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                System.Console.WriteLine("Enter your gender : ");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your phone number : ");
                long phone = long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your mail ID : ");
                string mail = Console.ReadLine();
                System.Console.WriteLine("Enter your physics mark : ");
                int physics = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your chemistry mark : ");
                int chemistry = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your maths mark : ");
                int maths = int.Parse(Console.ReadLine());

                StudentDetail student1 = new StudentDetail(name,fatherName,dob,gender,phone,mail,physics,chemistry,maths);
                studentList.Add(student1);

                System.Console.WriteLine("Are You Willing to admit?");
                willing = Console.ReadLine().ToLower();
            }while(willing=="yes");

        

            foreach(StudentDetail students in studentList)
            {
                System.Console.WriteLine("\nStudent  Details Are\n");
                System.Console.WriteLine("Name is "+students.Name+"\nFather name is "+students.FatherName+"\nDate of birth is "+students.DOB.ToString("dd/MM/yyyy")+"\nGender is "+students.Gender+"\nPhone number is "+students.Phone+"\nMail ID is "+students.Mail+"\nPhysics mark is "+students.Physics+"\nChemistry mark is "+students.Chemistry+"\nMaths mark is "+students.Maths);
                System.Console.WriteLine("Your Application number is "+students.ApplicationNumber);
                bool eligible = students.ChechEligibility(75.0);
                if(eligible)
                {
                    System.Console.WriteLine("Eligible for Admission");
                }
                else
                {
                    System.Console.WriteLine("Not Eligible for Admission ");
                }
            }    
            
        }
    }
}