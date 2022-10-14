using System;

using System.IO;

namespace OnlineMedical
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MedicalShop"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MedicalShop");
            }
            if(!File.Exists("MedicalShop/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MedicalShop/UserDetails.csv");
            }
            if(!File.Exists("MedicalShop/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creting File");
                File.Create("MedicalShop/MedicineDetails.csv");
            }
            if(!File.Exists("MedicalShop/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MedicalShop/OrderDetails.csv");
            }
        }

        public static void ReadFiles()
        {
            string [] users= File.ReadAllLines("MedicalShop/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user = new UserDetails(data);
                Operations.userList.Add(user);
            }

            string [] medicines = File.ReadAllLines("MedicalShop/MedicineDetails.csv");
            foreach(string data in medicines)
            {
                MedicineDetails medicine = new MedicineDetails(data);
                Operations.medicineList.Add(medicine);
            }
            string [] orders = File.ReadAllLines("MedicalShop/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order = new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }

        public static void WriteToFiles()
        {
            string [] userDetails = new string [Operations.userList.Count];
            for(int i = 0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;

            }
            File.WriteAllLines("MedicalShop/UserDetails.csv",userDetails);

            string [] medicineDetails = new string [Operations.medicineList.Count];
            for(int i = 0;i<Operations.medicineList.Count;i++)
            {
                medicineDetails[i]=Operations.medicineList[i].MedicineID+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvailableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("MedicalShop/MedicineDetails.csv",medicineDetails);

            string [] orderDetails = new string [Operations.orderList.Count];
            for(int i =0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserId+","+Operations.orderList[i].MedicineId+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalShop/OrderDetails.csv",orderDetails);
        }
    }
}