namespace WebApplication1
{
    // Startup.cs
    public class Startup
    {
        // ...

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Додайте інші сервіси, якщо потрібно
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ...

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // Додайте інші маршрути, якщо потрібно
            });
        }
    }

}
