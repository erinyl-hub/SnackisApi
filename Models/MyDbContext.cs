using Microsoft.EntityFrameworkCore;

namespace SnackisApi.Models
{

        public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
            {

            }

            public DbSet<Models.Report> Reports { get; set; }

        }
    
}
