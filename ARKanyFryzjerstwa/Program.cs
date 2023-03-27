using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace ARKanyFryzjerstwa
{
    public class Program
    {
        public const string ALLOWED_LOGIN_CHARS = "abcdefghijklmnopqrstuvwxyz0123456789_.";
        public const string NOTIFICATION_KEY = "notification";
        public static MailSettings MailSettings { get; private set; }
        public static IWebHostEnvironment Environment { get; private set; }
        public static MailboxAddress AppMail { get; private set; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityContext>()
                .AddErrorDescriber<PolishIdentityErrorDescriber>().AddDefaultTokenProviders(); ;

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;

                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = ALLOWED_LOGIN_CHARS;
            });

            MailSettings = builder.Configuration.GetSection("MailSettings").Get<MailSettings>();
            AppMail = MailboxAddress.Parse(MailSettings.AppMail);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options => 
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60);
            });
            
            var app = builder.Build();
            Environment = app.Environment;

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
