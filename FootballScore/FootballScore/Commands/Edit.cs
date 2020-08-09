using AutoMapper;
using FootballScore.Entities;
using FootballScore.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballScore.Commands
{
    public class Edit
    {
        public class UpdateGameRequest : IRequest<Game>
        {
            [Required]
            public int Id { get; set; }
            public string Player1 { get; set; }
            public string Player2 { get; set; }
            public int Player1Score { get; set; }
            public int Player2Score { get; set; }
            public DateTime Time { get; set; }
        }

        public class UpdateGameHandler : IRequestHandler<UpdateGameRequest, Game>
        {
            private readonly IMapper mapper;
            private readonly AppDbContext context;
            private readonly IMediator mediator;

            public UpdateGameHandler(IMapper mapper, AppDbContext context, IMediator mediator)
            {
                this.mapper = mapper;
                this.context = context;
                this.mediator = mediator;
            }
            public async Task<Game> Handle(UpdateGameRequest request, CancellationToken cancellationToken)
            {
                var result = mapper.Map<Game>(request);
                var updaded = context.Games.Update(result).Entity;

                await mediator.Publish(new EditedGameEvent { Id = updaded.Id });
                return updaded;
            }
        }
    }
}
