namespace ARKanyFryzjerstwa.Data
{
    public enum DatabaseTable
    {
        Appointments,
        Clients,
        ClientSalon,
        Resources,
        RoleClaims,
        Roles,
        Salons,
        ServiceResource,
        Services,
        TablesModificationDateTimes,
        UserClaims,
        UserLogins,
        UserRoles,
        Users,
        UserTokens,
        VerificationCodes
    }

    public class TableModification
    {
        public int SalonId { get; set; }
        public DatabaseTable Table { get; set; }
        public DateTime ModificationDateTime { get; set; }
    }
}
