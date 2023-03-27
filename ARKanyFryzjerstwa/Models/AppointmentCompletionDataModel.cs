namespace ARKanyFryzjerstwa.Models
{
    public class AppointmentCompletionDataModel
    {
        public int AppointmentId { get; set; }
        public string StandardPrice { get; set; }
        public string FinalPrice { get; set; }
        public List<ResourceUsageModel> Resources { get; set; }
    }
}
