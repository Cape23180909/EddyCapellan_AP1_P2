using EddyCapellan_AP1_P2.DAL;
using Microsoft.EntityFrameworkCore;

namespace EddyCapellan_AP1_P2.Services;

public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int RegistroId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro.AnyAsync(r => r.Id == RegistroId);
    }
}