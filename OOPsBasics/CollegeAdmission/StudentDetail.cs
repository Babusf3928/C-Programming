using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Used to process the college admission using this application
/// </summary>

namespace CollegeAdmission
{
    /// <summary>
    /// Used to select the student's gender
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// class the contains the student's information 
    /// </summary>
    public class StudentDetail
    {
        /// <summary>
        /// It is the static field used to give the unique application number to the student /<see cref="StudentDetail"/>
        /// </summary>
        private static int s_applicationNumber =0;    //private field

       // public string Name { get{return _name;} set{ name=value;} }
       /// <summary>
       /// It is the property that reads the Application number of the student /<see cref="StudentDetail" />
       /// </summary>
       /// <value></value>
        public int ApplicationNumber { get; }
        /// <summary>
        /// Property that gives the name of the student /<see cref="StudentDetail" />
        /// </summary>
        /// <value></value>
        
        public string Name { get; set; }
        /// <summary>
        /// Property which gives the father name of the student /<see cref="StudentDetail" />
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Property which gives the date of birth of the student /<see cref="StudentDetail"/>
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Property that gives the gender of the student /<see cref="StudentDetail"/>
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property that gives phone number of the student /<see cref="StudentDetail" />
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Property that gives the mail id of the student /<see cref="StudentDetail" />
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// Property that provides the physics mark of the student /<see cref="StudentDetail"/>
        /// </summary>
        /// <value></value>
        public int Physics { get; set; }
        /// <summary>
        /// Property that provides the chemistry mark of the student /<see cref="StudentDetail"/>
        /// </summary>
        /// <value></value>
        public int Chemistry { get; set; }
        /// <summary>
        /// Property that provides the maths mark of the student /<see cref="StudentDetail" />
        /// </summary>
        /// <value></value>
        public int Maths { get; set; }
        
        //public StudentDetail()            //Default Constructor
        //{
          //  Name= "Your name";
            //FatherName= "Your father name";
        //}
        /// <summary>
        /// It is the constructor which is used to assign the values in the variable to the Properties /<see cref="StudentDetail"/>
        /// </summary>
        /// <param name="name">parameter that contains the name provided by the user </param>
        /// <param name="fatherName">parameter that contains the fatheraName provided by the user </param>
        /// <param name="dob">parameter </param>
        /// <param name="gender"></param>
        /// <param name="phone"></param>
        /// <param name="mail"></param>
        /// <param name="physics"></param>
        /// <param name="chemistry"></param>
        /// <param name="maths"></param>
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
        
        public void ShowDetails()
        {
            System.Console.WriteLine("Application number is "+ApplicationNumber);
            System.Console.WriteLine("Name is "+Name+"\nFather name is "+FatherName+"\nDate of birth is "+DOB.ToString("dd/MM/yyyy")+"\nGender is "+Gender+"\nPhone number is "+Phone+"\nMail ID is "+Mail+"\nPhysics mark is "+Physics+"\nChemistry mark is "+Chemistry+"\nMaths mark is "+Maths);
        }
               
    }
}