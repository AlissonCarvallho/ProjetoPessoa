 

public class MeuDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-44G5FBD;Database=master;User Id=sa;Password=97878513901;");
    }
}

