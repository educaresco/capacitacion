using Microsoft.EntityFrameworkCore;
using Viacash.General.Api.Models;

namespace Viacash.General.Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions <DataContext> options):base(options) { }
        public DbSet<SenderWB> SendersWB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SenderWB>()
                .HasKey(c => new {c.ID_SENDER , c.ID_BRANCH } );
        }
    }
}
