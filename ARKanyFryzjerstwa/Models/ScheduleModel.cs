namespace ARKanyFryzjerstwa.Models
{
    public class ScheduleModel
    {
        public string MonthTitle { get; set; }
        public IList<ScheduleEmployeeDataModel> Employees { get; set; }
    }
}
