using EddyCapellan_AP1_P2.DAL;
using EddyCapellan_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Linq.Expressions;

namespace EddyCapellan_AP1_P2.Services;

public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    //public async Task<bool> Existe(int RegistroId)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();

    //}

    //public async Task<bool> Insertar(Registro registro)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();


    //}

    //public async Task<bool> Modificar(Registro registro)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();


    //}
    //public async Task<bool> Guardar(Registro registro)
    //{

    //}

    //public async Task<bool> Eliminar(int id)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();


    //}

    //public async Task<Registro?> Buscar(int id)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();

    //}

    //public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    //{
    //    await using var contexto = await DbFactory.CreateDbContextAsync();


    //}
}