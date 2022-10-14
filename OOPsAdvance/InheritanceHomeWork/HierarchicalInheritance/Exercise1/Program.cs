using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        TeacherInfo teacher1=new TeacherInfo("Babu","Periyasamy",9894007401,"babu20010704@gmail.com",new DateTime(2001,04,07),Gender.Male,"Chemical","Thermodynamics","M.phil",4,DateTime.Now);
        teacher1.ShowTeacher();

        StudentInfo student1=new StudentInfo("Babu","Periyasamy",9894007401,"babu20010704@gmail.com",new DateTime(2001,04,07),Gender.Male,"B,Tech","Chemical",8);
        student1.StudentDetail();

        PrincipalInfo principal1=new PrincipalInfo("Babu","Periyasamy",9894007401,"babu20010704@gmail.com",new DateTime(2001,04,07),Gender.Male,"M.Phil",7,DateTime.Now);
        principal1.ShowPrincipal();
    }
}
