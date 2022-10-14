using System;


namespace OnlineMedical
{
    public class UserDetails
    {
        private static int s_userId=1000;
        public string UserID { get;  }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }


        public UserDetails(string name,int age,string city,long phoneNumber)
        {
            s_userId++;
            UserID="UID"+s_userId;
            Name=name;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
        }

        public UserDetails(string data)
        {
            string [] values = data.Split(',');
            s_userId=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=long.Parse(values[4]);
            Balance=double.Parse(values[5]);
        }
    }
}