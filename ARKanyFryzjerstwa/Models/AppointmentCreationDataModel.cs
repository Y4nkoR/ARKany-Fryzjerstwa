using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.Models
{
    public class AppointmentCreationDataModel
    {
        public IDictionary<int, string> Clients { get; set; }

        public IList<AppointmentServiceModel> Services { get; set; }

        public IDictionary<string, string> Employees { get; set; }

    }
}
