using MVC2022.Models;

namespace MVC2022.Repositories.interfaces;

    public interface ICategoriaRepository
    {
    IEnumerable<Categoria> Categorias { get; }
    }

