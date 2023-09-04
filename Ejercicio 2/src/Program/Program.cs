using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient juan = new Patient("", "", 16, "091303033");
            Patient sofia = new Patient("Sofia Hernandez", "4724124-3", 43, "099112251");
            Doctor andrea = new Doctor("Andrea Boncialli", "Cardiologa");

            Appointment appointment = AppointmentService.CreateAppointment(juan, andrea, DateTime.Today, "Sede Central");
            string appointmentResult = AppointmentService.GetAppointmentStatus(appointment);
            Console.WriteLine(appointmentResult);
        }
    }
}
