namespace ARKanyFryzjerstwa.Models
{
    public class DisplayedResource
    {
        public DisplayedResource()
        { }
        public DisplayedResource(int id, string name, string unit)
        {
            Id = id;
            Name = name;
            Unit = unit;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
    }
}
