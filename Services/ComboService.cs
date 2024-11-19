using EddyCapellan_AP1_P2.DAL;
using EddyCapellan_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Linq.Expressions;

namespace EddyCapellan_AP1_P2.Services;

public class ComboService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int comboid)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos.AnyAsync(c => c.ComboId == comboid);

    }

    public async Task<bool> Insertar(Combos combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Combos.Add(combo);
        return await contexto.SaveChangesAsync() > 0;

    }

    public async Task<bool> Modificar(Combos combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Combos.Update(combo);
        return await contexto.SaveChangesAsync() > 0;


    }
    public async Task<bool> Guardar(Combos combo)
    {
        if (!await Existe(combo.ComboId))
            return await Insertar(combo);
        else
            return await Modificar(combo);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var eliminando = await contexto.Combos
            .Where(c =>c.ComboId == id)
            .ExecuteDeleteAsync();
        return eliminando > 0;

    }

    public async Task<Combos?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .AsNoTracking()
            .FirstOrDefaultAsync( c =>c.ComboId == id);

    }

    public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return  await contexto.Combos
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}