using EddyCapellan_AP1_P2.DAL;
using EddyCapellan_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Linq.Expressions;

namespace EddyCapellan_AP1_P2.Services;

public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int RegistroId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro.AnyAsync(r => r.Id == RegistroId);
    }

    public async Task<bool> Insertar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Registro.Add(registro);
        return await contexto.SaveChangesAsync() > 0;

    }

    public async Task<bool> Modificar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Registro.Update(registro);
        return await contexto.SaveChangesAsync() > 0;

    }
    public async Task<bool> Guardar(Registro registro)
    {
        if (!await Existe(registro.Id))
            return await Insertar(registro);
        else
            return await Modificar(registro);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var eliminado = await contexto.Registro
           .Where(r => r.Id == id)
           .ExecuteDeleteAsync();
        return eliminado > 0;

    }

    public async Task<Registro?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Id == id);

    }

    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();

    }
}