using Microsoft.EntityFrameworkCore;

namespace TP_SISTEMAS_DISTRIBUIDOS_V5
{
    public class MigrationService
    {
        public static void InitializeMigration(IApplicationBuilder app) 
        { 
            using var serviceScope = app.ApplicationServices.CreateScope();
            serviceScope.ServiceProvider.GetService<ApplicationDbContext>()!.Database.Migrate();
        }
    }
}
