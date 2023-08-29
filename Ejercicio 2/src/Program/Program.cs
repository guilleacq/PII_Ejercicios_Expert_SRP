using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Steven Jhonson", "986782342", "5555-555-555");
            string appointmentResult = AppointmentService.CreateAppointment(client1, DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            Client client2 = new Client("Ralf Manson", "", "5555-555-555");
            string appointmentResult2 = AppointmentService.CreateAppointment(client2, DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
