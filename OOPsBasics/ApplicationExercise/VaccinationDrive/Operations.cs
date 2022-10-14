using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    static public class Operations
    {
        static BeneficiaryDetails currentUser=null;
        static List<BeneficiaryDetails> beneficiaryList = new List<BeneficiaryDetails>();

        static List<VaccineDetails> vaccineList = new List<VaccineDetails>();

        static List<VaccinationDetails> vaccinationList = new List<VaccinationDetails>();


        public static void DefaultData()
        {
            BeneficiaryDetails beneficiary1 = new BeneficiaryDetails("Ravichandran",Gender.Male,8484484,"Chennai",21);
            beneficiaryList.Add(beneficiary1);
            BeneficiaryDetails beneficiary2 = new BeneficiaryDetails("Baskaran",Gender.Male,8484747,"Chennai",22);
            beneficiaryList.Add(beneficiary2);
            VaccineDetails vaccine1 = new VaccineDetails(VaccineName.Covishield,50);
            vaccineList.Add(vaccine1);
            VaccineDetails vaccine2 = new VaccineDetails(VaccineName.Covaccine,50);
            vaccineList.Add(vaccine2);
            VaccinationDetails vaccination1 = new VaccinationDetails(beneficiary1.RegistrationNumber,vaccine1.VaccineID,1,new DateTime(2021,11,11));
            vaccinationList.Add(vaccination1);
            VaccinationDetails vaccination2 = new VaccinationDetails(beneficiary1.RegistrationNumber,vaccine1.VaccineID,2,new DateTime(2022,03,11));
            vaccinationList.Add(vaccination2);
            VaccinationDetails vaccination3 = new VaccinationDetails(beneficiary2.RegistrationNumber,vaccine2.VaccineID,1,new DateTime(2022,04,04));
            vaccinationList.Add(vaccination3);
        }
        
        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.BeneficiaryRegistration 2.Login 3.GetVaccineInfo 4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("BeneficiaryRegistration");
                        BeneficiaryRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("GetVaccineInfo");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }

                }
            }while(choice=="yes");
        }

        public static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your mobile number : ");
            long mobileNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city : ");
            string city = Console.ReadLine();
            
            BeneficiaryDetails beneficiary3 = new BeneficiaryDetails(name,gender,mobileNumber,city,age);
            beneficiaryList.Add(beneficiary3);

            System.Console.WriteLine("Your Registration ID is :"+beneficiary3.RegistrationNumber);

        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration number : ");
            string registerNumber = Console.ReadLine();
            foreach(BeneficiaryDetails user in beneficiaryList)
            {
                if(user.RegistrationNumber==registerNumber)
                {
                    System.Console.WriteLine("Login Successful");
                    currentUser=user;
                    SubMenu();

                }
                
            }
        }

        public static void SubMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Show My Detatils 2.Take Vaccination 3.My Vaccination History 4.Next Due Date 5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show My Deatails");
                        ShowMyDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Take Vaccination");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("My Vaccination History");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Next Due Date");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit");
                        break;
                    }
                }
            } while(choice=="yes");
        }

        public static void ShowMyDetails()
        {
            foreach(BeneficiaryDetails user1 in beneficiaryList)
            {
                if(currentUser.RegistrationNumber==user1.RegistrationNumber)
                {
                    System.Console.WriteLine($"Your name is {user1.RegistrationNumber}\nYour name is {user1.Name}\nYour gender is {user1.Gender}\nYour mobile number is {user1.MobileNumber}\nYour city is {user1.City}\nYour age is {user1.Age}");

                }
            }
        }

        public static void TakeVaccination()
        {
            foreach(VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"Vaccine ID is {vaccine.VaccineID}\tVaccine name is {vaccine.VaccineName}\tNumber of doses available is {vaccine.NumberOfDoses} ");
                
            }
            System.Console.WriteLine("Enter the vaccine ID :  ");
            string vaccineId=Console.ReadLine();
            foreach(VaccineDetails userVaccine in vaccineList)
            {
                if(userVaccine.VaccineID==vaccineId)
                {
                    
                }
            }
        }
    }
}