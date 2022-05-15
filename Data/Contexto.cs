using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


public class Contexto:DbContext
{
    public DbSet<Ocupacion>? Ocupaciones { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"data source=DataBase/OcupacionesDB.db");
        
    }
 }
