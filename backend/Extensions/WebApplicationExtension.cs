namespace PcShop.Extensions;

using Data;

public static class WebApplicationExtension
{

    public static async Task RunMigrations(this WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider
            .GetRequiredService<AppDbContext>();

        await db.Database.MigrateAsync();
    }


    public static void EnableSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();

            // Serve the interactive Swagger UI
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(
                    "/openapi/v1.json",
                    "API v1"
                );
            });
        }
    }
}
