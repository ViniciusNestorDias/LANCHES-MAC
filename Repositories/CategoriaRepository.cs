using Microsoft.EntityFrameworkCore;
using MVC2022.Context;
using MVC2022.Models;
using MVC2022.Repositories.interfaces;

namespace MVC2022.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;
    public CategoriaRepository(AppDbContext context)
    {
    _context = context; 
    }
    public IEnumerable<Categoria> Categorias => throw new NotImplementedException();
}

