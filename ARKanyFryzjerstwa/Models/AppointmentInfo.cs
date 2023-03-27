namespace ARKanyFryzjerstwa.Models
{
    public class AppointmentInfo
    {
        public int AppointmentId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeColor { get; set; }
        public string ServiceName { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool IsCompleted { get; set; }
        public string? StandardPrice { get; set; }
        public string? FinalPrice { get; set; }
    }
}
