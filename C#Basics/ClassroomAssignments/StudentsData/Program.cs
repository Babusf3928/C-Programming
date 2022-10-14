using System;
namespace StudentsData
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your student name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your father's name : ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter your mail.id : ");
            object mail = Console.ReadLine();
            Console.WriteLine("Enter your phoneNumber : ");
            long phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender : ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Maths mark: ");
            float maths = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry mark: ");
            float chem = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Physics mark: ");
            float phy = float.Parse(Console.ReadLine());
            float sum = maths+chem+phy;
            float average = sum/3;
            Console.WriteLine("The Student name is "+name+" and his father's name is "+fatherName+". The student's mail id is "+mail+" and his phone number is "+phone+" and also his age is "+age+". The Student is a "+gender+".");
            Console.WriteLine("The Average of the marks is " +average);
            Console.WriteLine("The Percentage of the marks is " +((sum)/600)*100 +"%");
            



            
        }
    }
}
    