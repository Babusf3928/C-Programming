using System;


namespace StudentAdmission
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentID = 3000;
        public string StudentID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,int physics,int chemistry,int maths)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public StudentDetails(string data)
        {
            string[] values=data.Split(',');
            s_studentID = int.Parse(values[0].Remove(0,2));
            StudentID=values[0];
            Name=values[1];
            FatherName=values[2];
            DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Gender=Enum.Parse<Gender>(values[4]);
            Physics=int.Parse(values[5]);
            Chemistry=int.Parse(values[6]);
            Maths=int.Parse(values[7]);
        }

        public bool CheckEligibility(double cutOff)
        {
            double average = (double)(Physics+Chemistry+Maths)/3.0;
            if(average >= cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Student name is {Name}\nFather name is {FatherName}\nDate of birth is {DOB.ToString("dd/MM/yyyy",null)}\nStudent gender is {Gender}\nStudent physics mark is {Physics}\nStudent chemistry mark is {Chemistry}\nStudent maths mark is {Maths} ");
            
        }
        
    }
}