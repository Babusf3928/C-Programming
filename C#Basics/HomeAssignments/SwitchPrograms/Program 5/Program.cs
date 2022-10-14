using System;
namespace Program5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the country name : ");
            string country = Console.ReadLine();
            switch(country)
            {
                case "India":
                {
                    Console.WriteLine("1. Gambir\n2. Ashwin\n3. Dhoni\n4. Jadeja");
                    break;
                }
                case "Pakistan":
                {
                    Console.WriteLine("1. Babar Azam\n2. Shaheen Afridi\n3. Hasan Ali\n4. Shoaib Malik");
                    break;
                }
                case "Bangladesh":
                {
                    Console.WriteLine("1. Shakib Al Hasan\n2. Tamim Iqbal\n3. Mustafizur Rahman\n4. Litton Das");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Option");
                    break;
                }

            }
        }
    }
}