namespace ARKanyFryzjerstwa.Models
{
    public class ScheduleData
    {
        public string Title { get; set; }
        public IList<ScheduleDay> Days { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
    }
}
