﻿using Microsoft.EntityFrameworkCore;

namespace EddyCapellan_AP1_P2.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options)
          : base(options) { }
}
