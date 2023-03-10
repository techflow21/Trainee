using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace TraineeManagementApp.DAL.Entities
{
    public class TraineeManagementAppDbFactory : IDesignTimeDbContextFactory<TraineeManagementAppDbContext>
    {
        public TraineeManagementAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TraineeManagementAppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=desktop-apmjtig;Initial Catalog=TraineeMgtDB;Integrated Security=True;Encrypt=false");

            return new TraineeManagementAppDbContext(optionsBuilder.Options);
        }
    }
}
