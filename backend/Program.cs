namespace PcShop;

using Data;

public class Program
{
    private static readonly WebApplicationBuilder s_builder = WebApplication.CreateBuilder();
    private static WebApplication? s_app;

    public static async Task Main()
    {
        s_builder.Services.AddOpenApi();
        s_builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(s_builder.Configuration.GetConnectionString("DefaultConnection")));

        s_app = s_builder.Build();
        await RunMigrations();
        EnableSwagger();

        s_app.UseHttpsRedirection();


        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        s_app.MapGet("/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();
            return forecast;
        })
        .WithName("GetWeatherForecast");

        s_app.Run();

    }

    private static void EnableSwagger()
    {
        if (s_app != null && s_app.Environment.IsDevelopment())
        {
            s_app.MapOpenApi();

            // Serve the interactive Swagger UI
            s_app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(
                    "/openapi/v1.json",
                    "API v1"
                );
            });
        }
    }

    private static async Task RunMigrations()
    {
        if (s_app == null)
        {
            return;
        }
        var scope = s_app.Services.CreateScope();
        var db = scope.ServiceProvider
            .GetRequiredService<AppDbContext>();

        await db.Database.MigrateAsync();
    }

    record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
