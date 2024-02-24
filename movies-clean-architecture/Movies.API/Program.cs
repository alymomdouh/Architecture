using Movies.Infrastructure.Data;

namespace Movies.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuild(args).Build();
            await createAndSeeds(host);
            host.Run();
        }
        private static IHostBuilder CreateHostBuild(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults((config) =>
            {
                config.UseStartup<Startup>();
            });

        private static async Task createAndSeeds(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<MovieDbContext>();
                    await MovieContextSeed.SeedAsync(context, loggerFactory);
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError($"Exception in run And Seeding Default Data");
                }
            }
        }
    }
}