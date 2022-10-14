using System;


namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the class that consists of theatre details
    /// </summary>
    public class TheatreDetails
    {
        /// <summary>
        /// 
        /// </summary>
        private static int s_theatreId = 300;
        /// <summary>
        /// It is the property that refers to the theatre id
        /// </summary>
        /// <value></value>
        public string TheatreId { get; }
        /// <summary>
        /// It is the property that refers to theatre name 
        /// </summary>
        /// <value></value>
        public string TheatreName { get; set; }
        /// <summary>
        /// It is the property that refers to location of the theatre
        /// </summary>
        /// <value></value>
        public string TheatreLocation { get; set; }
        /// <summary>
        /// It is the parameterised constructor is used to assign the properties to the variable where the details are stored
        /// </summary>
        /// <param name="theatreName"></param>It is the variable assigned to the theatre name property
        /// <param name="theatreLocation"></param>It is the variable assigned to the location of theatre property

        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }

        public TheatreDetails(string data)
        {
            string [] values = data.Split(","); 
            s_theatreId = int.Parse(values[0].Remove(0,3));
            TheatreId=values[0];
            TheatreName=values[1];
            TheatreLocation=values[2];
        }

    }
}