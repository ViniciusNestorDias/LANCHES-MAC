using Microsoft.AspNetCore.Mvc;
using MVC2022.Repositories.interfaces;

namespace MVC2022.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LancheController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }
    public IActionResult List()
    {
        var lanches = _lancheRepository.Laches;
        var totalLanches = lanches.Count();
        return View(lanches);
    }
}

