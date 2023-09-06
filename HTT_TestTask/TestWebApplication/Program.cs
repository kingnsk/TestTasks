using Microsoft.EntityFrameworkCore;
using TestWebApplication.Data;

namespace TestWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Configure EF DBContext Service 

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["Settings:DatabaseOptions:ConnectionString"],
                builder => builder.EnableRetryOnFailure());
            });

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

	    app.MapControllerRoute(
		name: "getProductsByCategory",
		pattern: "Product/GetProductsByCategory/{categoryId}",
                defaults: new {controller = "Product", action = "GetProductsByCategory" });

	    app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}");

            app.Run();
        }
    }
}