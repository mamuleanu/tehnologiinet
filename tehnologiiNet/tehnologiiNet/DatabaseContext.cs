using Microsoft.EntityFrameworkCore;
using tehnologiiNet.Entities;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace tehnologiiNet;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
        
        
        
    }

    public DatabaseContext()
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=net;Username=postgres;Password=parkingshare");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    public DbSet<DemoEntity> DemoEntities { get; set; }
}