namespace ARKanyFryzjerstwa.Models
{
    public class EmployeeAppointmentsCounts
    {
        public string EmployeeId { get; set; }
        public int NotCanceledAppointmentsCount { get; set; }
        public int CompletedAppointmentsCount { get; set; }
        public int NewClientsAppointmentsCount { get; set; }
    }
}
