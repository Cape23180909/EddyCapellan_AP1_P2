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
            new Articulos() {ArticuloId= 1, Descripcion ="Monitor", Costo=500, Ganancia=30, Precio=1000},
            new Articulos { ArticuloId= 2, Descripcion  = "Laptop", Costo=50000, Ganancia=20, Precio=70000 },
            new Articulos { ArticuloId= 3, Descripcion  = "Computadora", Costo= 30, Ganancia=15, Precio=25}
        });
    }
}
