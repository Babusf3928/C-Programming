using System;


namespace OnlineMedical
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineID="MD"+s_medicineId;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

        public MedicineDetails(string data)
        {
            string [] values = data.Split(",");
            s_medicineId=int.Parse(values[0].Remove(0,2));
            MedicineID=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price=double.Parse(values[3]);
            DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }


    }
}