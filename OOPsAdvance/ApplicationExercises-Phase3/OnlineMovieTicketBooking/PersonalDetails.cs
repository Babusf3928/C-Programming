using System;


namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the class that consists of personal details of the personal details of the user
    /// </summary>
    public  class PersonalDetails
    {
        /// <summary>
        /// It is the property that refers to name of the user
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// It is the property that refers to age of the user
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// It is the property that refers to the phone number of the user
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// It is the parameterised constructor is used to assign the properties to the variable where the details are stored
        /// </summary>
        /// <param name="name"></param>It is the variable assigned to the name property
        /// <param name="age"></param>It is the variable assigned to the age property
        /// <param name="phoneNumber"></param>It is the variable assigned to the phoneNumber property

        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
        /// <summary>
        /// It is the default constructor
        /// </summary>
        public PersonalDetails()
        {

        }
    }
}