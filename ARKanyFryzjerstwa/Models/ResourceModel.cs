using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.Models
{
    public class ResourceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public ResourceUnit Unit { get; set; }
        public string AlertQuantity { get; set; }
    }
}
