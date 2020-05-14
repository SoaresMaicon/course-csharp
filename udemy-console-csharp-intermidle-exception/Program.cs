using System;
using udemy_console_csharp_intermidle_exception.Entities;

namespace udemy_console_csharp_intermidle_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number:");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine(reservation.ToString());

            }
            catch (DomainException E )
            {
                Console.WriteLine("Error in Reservation. " + E.Message);
            }
            catch(FormatException E)
            {
                Console.WriteLine("Error in conversion data. " + E.Message);
            }
            catch(Exception E)
            {
                Console.WriteLine("Unexpected error. " + E.Message);
            }


        }
    }
}
