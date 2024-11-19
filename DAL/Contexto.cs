using EddyCapellan_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace EddyCapellan_AP1_P2.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options)
          : base(options) { }
    public DbSet<Articulos> Articulos { get; set; }
    public DbSet<Combos> Combos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Articulos>().HasData(new List<Articulos>()
        {
            new Articulos() {ArticuloId= 1, Descripcion ="Monitor"},
            new Articulos { ArticuloId= 2, Descripcion  = "Laptop" },
            new Articulos { ArticuloId= 3, Descripcion  = "Computadora" }
        });
    }
}
