using System;
namespace Program6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input radius of the circle : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the choice \n1.Area \n2.Perimeter\n3.Diameter");
            int choice = int.Parse(Console.ReadLine());
            double area =(3.14*(radius*radius));
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("The area of the circle is "+area);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("The perimeter of the circle is "+(2*3.14*radius));
                    break;
                }
                case 3:
                {
                    Console.WriteLine("The diameter of the circle is "+(2*radius));
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