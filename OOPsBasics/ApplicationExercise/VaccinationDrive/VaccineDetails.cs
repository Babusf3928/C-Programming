using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum VaccineName{Default,Covishield,Covaccine}
    public class VaccineDetails
    {
        private static int s_vaccineID=100;
        public string VaccineID { get;}
        public VaccineName VaccineName { get; set; }
        public int NumberOfDoses { get; set; }

        public VaccineDetails(VaccineName vaccineName,int numberOfDoses)
        {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=vaccineName;
            NumberOfDoses=numberOfDoses;
        }

    }
}