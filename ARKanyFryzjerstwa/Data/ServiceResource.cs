namespace ARKanyFryzjerstwa.Data
{
    public class ServiceResource
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
        public float Usage { get; set; }
    }
}
