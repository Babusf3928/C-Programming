

namespace AdmissionLibrary
{  
    public enum Gender{Default,Male,Female,Transgender}
   
    public class StudentDetail
    {
        private static int s_applicationNumber =0;    //private field

       // public string Name { get{return _name;} set{ name=value;} }
        public int ApplicationNumber { get; }
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        
        //public StudentDetail()
        //{
          //  Name= "Your name";
            //FatherName= "Your father name";
        //}
        public StudentDetail(string name,string fatherName,DateTime dob,Gender gender,long phone,string mail,int physics,int chemistry,int maths)
        {
            s_applicationNumber++;
            ApplicationNumber=s_applicationNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public bool ChechEligibility(double cutOff)
        {
            double average = (double)(Physics+Chemistry+Maths)/6.0;
            if(average >= cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
               
    }
}