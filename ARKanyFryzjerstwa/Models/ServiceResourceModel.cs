using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.Models
{
    public class ServiceResourceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Usage { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }
}
