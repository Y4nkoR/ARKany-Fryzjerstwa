namespace ARKanyFryzjerstwa.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }
        public IList<ServiceResourceModel> Resources { get; set; }
        public bool IsActive { get; set; }
    }
}
