﻿using Microsoft.EntityFrameworkCore;
using MVC2022.Models;

namespace MVC2022.Context;

    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
      {

      }

    public DbSet<Categoria>Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }

    }

