using System;


namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the class that consists of movie details
    /// </summary>
    public class MovieDetails
    {
        /// <summary>
        /// It is the field for the movie id used for the increment
        /// </summary>
        private static int s_movieId=500;
        /// <summary>
        /// It is the property refers the movie id
        /// </summary>
        /// <value></value>
        public string MovieID { get; }
        /// <summary>
        /// It is the property refers to the movie name of the movie
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        /// It is the property refers to the language of the movie
        /// </summary>
        /// <value></value>
        public string Language { get; set; }

        /// <summary>
        /// Iyt is the parameterised constructor used for assigning values to the properties
        /// </summary>
        /// <param name="movieName"></param> It is variable assigned to the movie name of the property
        /// <param name="language"></param> It is variable assigned to the language of the movie property

        public MovieDetails(string movieName,string language)
        {
            s_movieId++;
            MovieID="MID"+s_movieId;
            MovieName=movieName;
            Language=language;
        }

        public MovieDetails(string data)
        {
            string [] values = data.Split(",");
            s_movieId = int.Parse(values[0].Remove(0,3));
            MovieID=values[0];
            MovieName=values[1];
            Language=values[2];
        }
    }
}