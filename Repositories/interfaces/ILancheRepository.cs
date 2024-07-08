using MVC2022.Models;

namespace MVC2022.Repositories.interfaces;

    public interface ILancheRepository
    {
        IEnumerable<Lanche> Laches { get; }
        IEnumerable<Lanche> LachesPreferidos { get; }
        Lanche GetLancheByID(int LancheId);
}

