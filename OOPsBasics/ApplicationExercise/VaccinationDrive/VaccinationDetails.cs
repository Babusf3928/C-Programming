using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    
    public class VaccinationDetails
    {
        private static int s_vaccinationID=1000;
        public string VaccinationID { get;}
        public string RegistrationNumber { get; set; }
        public string  VaccineID { get; set; }
        public int DoseNumber {get; set;}
        public DateTime VaccinatedDate { get; set;}

        public VaccinationDetails(string registrationNumber,string vaccineID,int doseNumber,DateTime vaccinatedDate)
        {
            s_vaccinationID++;
            VaccinationID="VID"+1000;
            RegistrationNumber=registrationNumber;
            VaccineID=vaccineID;
            DoseNumber=doseNumber;
            VaccinatedDate=vaccinatedDate;

        }
        
    }
}