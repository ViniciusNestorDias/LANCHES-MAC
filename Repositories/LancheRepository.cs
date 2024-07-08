using Microsoft.EntityFrameworkCore;
using MVC2022.Context;
using MVC2022.Models;
using MVC2022.Repositories.interfaces;

namespace MVC2022.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;
    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Lanche> Laches => _context.Lanches.Include(c => c.Categoria);

    public IEnumerable<Lanche> LachesPreferidos => _context.Lanches.Where(i => i.IsLanchePreferido).Include(c => c.Categoria);

    public Lanche GetLancheByID(int LancheId)
    {
        return _context.Lanches.FirstOrDefault(l => l.LancheId == LancheId);
    }
}

