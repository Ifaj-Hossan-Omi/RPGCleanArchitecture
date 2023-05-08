using Microsoft.AspNetCore.Mvc;
using RPG.Application.Abstraction.Service;

namespace RPG.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FightController : ControllerBase
{
    private readonly IFightService _fightService;

    public FightController(IFightService fightService)
	{
        _fightService = fightService;
    }
}

