using EddyCapellan_AP1_P2.DAL;
using EddyCapellan_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EddyCapellan_AP1_P2.Services;

public class ArticuloService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int articuloid)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos.AnyAsync(c => c.ComboId == articuloid);

    }

    public async Task<bool> Insertar(Articulos articulo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Articulos.Add(articulo);
        return await contexto.SaveChangesAsync() > 0;

    }

    public async Task<bool> Modificar(Articulos articulo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Articulos.Update(articulo);
        return await contexto.SaveChangesAsync() > 0;
    }
    public async Task<bool> Guardar(Articulos articulo)
    {
        if (!await Existe(articulo.ArticuloId))
            return await Insertar(articulo);
        else
            return await Modificar(articulo);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var eliminando = await contexto.Articulos
            .Where(c => c.ArticuloId == id)
            .ExecuteDeleteAsync();
        return eliminando > 0;

    }

    public async Task<Articulos?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Articulos
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.ArticuloId == id);

    }

    public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Articulos
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
