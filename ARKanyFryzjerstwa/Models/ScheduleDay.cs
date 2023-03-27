using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.Models
{
    public class ScheduleDay
    {
        public string Title { get; set; }
        public IList<AppointmentInfo> Appointments { get; set; }
    }
}
