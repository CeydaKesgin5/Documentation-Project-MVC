using Microsoft.EntityFrameworkCore;

namespace Evo.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Model sınıfını tabloyla eşle
            modelBuilder.Entity<Request>()
                .ToTable("tbl_api_doc")
                .HasKey(r => r.Id); ; // Tablo adı burada belirtilir
        }

        public DbSet<Request> Requests { get; set; }
    }
}
