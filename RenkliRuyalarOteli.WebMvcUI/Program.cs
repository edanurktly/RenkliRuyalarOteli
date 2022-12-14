using RenkliRuyalarOteli.BL.Abstract;
using RenkliRuyalarOteli.BL.Concrete;

namespace RenkliRuyalarOteli.WebMvcUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IKullaniciManager, KullaniciManager>();
            builder.Services.AddScoped<IMusteriManager, MusteriManager>();
            builder.Services.AddScoped<IOdaManager, OdaManager>();
            builder.Services.AddScoped<IOdaFiyatManager, OdaFiyatManager>();
            builder.Services.AddScoped<IOdaManager, OdaManager>();
            builder.Services.AddScoped<IRezervasyonDetayManager, RezervasyonDetayManager>();
            builder.Services.AddScoped<RezervasyonManager, RezervasyonManager>();





            var app = builder.Build();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}