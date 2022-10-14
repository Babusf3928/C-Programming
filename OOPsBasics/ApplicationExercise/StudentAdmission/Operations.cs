using System;


namespace StudentAdmission
{
    public delegate void EventManager();
    public  class Operations
    {
        public static event EventManager eventLink = null; 

        public static void Subscribe()
        {
            eventLink += new EventManager(Files.Create);

            eventLink += new EventManager(Files.ReadFile);

            eventLink += new EventManager(Operations.MainMenu);

            eventLink += new EventManager(Files.WriteToFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }
        static StudentDetails currentStudent = null;
        public static List<StudentDetails> studentList = new List<StudentDetails>();

        public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        
        public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();
        public static void MainMenu()
        {
            

            string choice ="yes";
            do
            {
                System.Console.WriteLine("Select 1.Student Registration 2.Student Login 3.Check Department Seats 4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Student Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Student Login");
                        Login(); 
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Check Department Seats");
                        DepartmentSeatAvailability();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice ="no";
                        break;
                    }
                }
            }while(choice=="yes");
            
        }

        

        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your father name : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your gender : ");
            Gender gender =Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your physics mark : ");
            int physics = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your chemistry mark : ");
            int chemistry = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark : ");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student3 = new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
            studentList.Add(student3);
            System.Console.WriteLine("Your student ID is : "+student3.StudentID);
        }


        

        public static void Login()
        {
            System.Console.WriteLine("Enter your student ID : ");
            string studentID = Console.ReadLine();
            foreach(StudentDetails student1 in studentList)
            {
                if(student1.StudentID==studentID)
                {
                    System.Console.WriteLine("Login Successfully ");
                    currentStudent=student1;
                    SubMenu();

                }
                
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select 1.Check Eligibility 2.Show Details 3.Take Admission 4.Cancel Admission 5.Show Admission Details 6.Exit ");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Check Eligibility");
                        bool eligible = currentStudent.CheckEligibility(75.0);
                        if(eligible)
                        {
                            System.Console.WriteLine("You are eligible");
                        }
                        else
                        {
                            System.Console.WriteLine("You are not eligible");
                        }
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show Details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Take Admission");
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Cancel Admission");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Show Admission Details");
                        ShowAdmissionDetails();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void TakeAdmission()
        {
            foreach(DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine($"Department ID is {department.DepartmentID} \tDepartment Name is {department.DepartmentName}\t Number of Seats in the department is {department.NumberOfSeats}");
            }
            System.Console.WriteLine("Enter the Department ID : ");
            string chooseDepartment = Console.ReadLine();
            foreach(DepartmentDetails select in departmentList)
            {
                if(select.DepartmentID==chooseDepartment)
                {
                    if(select.NumberOfSeats>=1)
                    {
                        bool eligible = currentStudent.CheckEligibility(75.0);
                        if(eligible)
                        {
                            bool canAdmit=true;
                            foreach(AdmissionDetails tempStudent in admissionList)
                            {
                                if(currentStudent.StudentID==tempStudent.StudentID)
                                {
                                    if(tempStudent.AdmissionStatus==Admissionstatus.Booked)
                                    {
                                        System.Console.WriteLine("Student Admission is already booked");
                                        canAdmit=false;
                                    }
                                    
                                }
                                
                            }
                            if(canAdmit)
                            {
                                foreach(DepartmentDetails tempDepartment in departmentList)
                                {
                                    if(chooseDepartment==tempDepartment.DepartmentID)
                                    {
                                        tempDepartment.NumberOfSeats--;
                                        AdmissionDetails admission3 = new AdmissionDetails(currentStudent.StudentID,tempDepartment.DepartmentID,DateTime.Now,Admissionstatus.Booked);
                                        admissionList.Add(admission3);
                                        System.Console.WriteLine("Admission took successfully \n Your Admission ID is "+admission3.AdmissionID);
                                    }
                                }
                            }
                        }
                        
                        
                        
                    }
                    else
                    {
                        System.Console.WriteLine("No Seats are available");
                    }
                }
            }
        }

        public static void CancelAdmission()
        {
            foreach(AdmissionDetails cancel in admissionList)
            {
                if(cancel.StudentID==currentStudent.StudentID)
                {
                    if(cancel.AdmissionStatus==Admissionstatus.Booked)
                    {
                        cancel.AdmissionStatus=Admissionstatus.NotBooked;
                        foreach(DepartmentDetails seat in departmentList)
                        {
                            if(cancel.DepartmentID==seat.DepartmentID )
                            {
                                seat.NumberOfSeats++;
                                System.Console.WriteLine("Admission Cancelled Successfully");
                            }
                        }
                    }
                }
            }
        }

        public static void ShowAdmissionDetails()
        {
            foreach(AdmissionDetails admissionDetail in admissionList)
            {
                if(currentStudent.StudentID==admissionDetail.StudentID)
                {
                    System.Console.WriteLine($"Admission ID is {admissionDetail.AdmissionID} \nStudent ID is {admissionDetail.StudentID} \nDepartment ID is {admissionDetail.DepartmentID} \nAdmission Date is {admissionDetail.AdmissionDate} \nAdmission Status is {admissionDetail.AdmissionStatus}");
                }
            }
        }

        public static void DepartmentSeatAvailability()
        {
            foreach(DepartmentDetails seatAvailable in departmentList)
            {
                System.Console.WriteLine($"Department ID is {seatAvailable.DepartmentID} \tDepartment Name is {seatAvailable.DepartmentName}\t Number of Seats in the department is {seatAvailable.NumberOfSeats}");
            }
        }

        


    }
}