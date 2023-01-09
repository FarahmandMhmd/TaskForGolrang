using Microsoft.EntityFrameworkCore;
using Portal.Domain.Users;
using System.Reflection;

namespace Portal.DataAccess;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "data source =.; initial catalog =dbGolrang; integrated security = True; MultipleActiveResultSets=True";
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
    
}
