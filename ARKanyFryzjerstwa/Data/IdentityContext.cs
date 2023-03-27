using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ARKanyFryzjerstwa.Data
{
    public class IdentityContext : IdentityDbContext<User>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<VerificationCode> VerificationCodes { get; set; }
        public DbSet<ClientSalon> ClientSalon { get; set; }
        public DbSet<ServiceResource> ServiceResource { get; set; }
        public DbSet<TableModification> TablesModificationDateTimes { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });

            builder.Entity<Service>().Property(p => p.Price).HasPrecision(8, 4);

            builder.Entity<ClientSalon>().HasKey(cs => new { cs.ClientId, cs.SalonId });

            builder.Entity<ServiceResource>().HasKey(sr => new { sr.ServiceId, sr.ResourceId });
            builder.Entity<ServiceResource>().HasOne(sr => sr.Service).WithMany(s => s.ServiceResources).HasForeignKey(sr => sr.ServiceId);
            builder.Entity<ServiceResource>().HasOne(sr => sr.Resource).WithMany(r => r.ServiceResources).HasForeignKey(sr => sr.ResourceId);

            builder.Entity<TableModification>().HasKey(tm => new { tm.SalonId, tm.Table });
			
            builder.Entity<Note>().HasIndex(c => c.EmployeeId).IsUnique();
        }
    }
}
