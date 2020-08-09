using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FootballScore.Commands.Create;
using static FootballScore.Commands.Edit;
using static FootballScore.Queries.All;

namespace FootballScore.Controllers
{
    public class GamesController : Controller
    {
        private readonly IMediator mediator;

        public GamesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> GetAll()
        {
            var result = await mediator.Send(new GetAllRequest { });
            return View(result);
        }

        public async Task<IActionResult> Post(AddGameRequest request)
        {
            var result = await mediator.Send(request);
            return View(result);
        }

        public async Task<IActionResult> Put(UpdateGameRequest request)
        {
            var result = await mediator.Send(request);
            return View(result);
        }

    }
}
