namespace ARKanyFryzjerstwa.Models
{
    public class HomepageStatisticsModel
    {
        public int CurrentUserPlannedAppointmentsCount { get; set; }
        public int CurrentUserServedClientsCount { get; set; }
        public int CurrentUserNewClientsCount { get; set; }

        public int OverallPlannedAppointmentsCount { get; set; }
        public int OverallServedClientsCount { get; set; }
        public int OverallNewClientsCount { get; set; }
    }
}
