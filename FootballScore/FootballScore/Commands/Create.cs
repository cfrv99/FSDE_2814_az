using AutoMapper;
using FootballScore.Entities;
using FootballScore.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballScore.Commands
{
    public class Create
    {
        public class AddGameRequest : IRequest<Game>
        {
            public string Player1 { get; set; }
            public string Player2 { get; set; }
            public int Player1Score { get; set; }
            public int Player2Score { get; set; }
            public DateTime Time { get; set; }
        }


        public class AddGameHandler : IRequestHandler<AddGameRequest, Game>
        {
            private readonly IMapper mapper;
            private readonly AppDbContext context;
            private readonly IMediator mediator;

            public AddGameHandler(IMapper mapper,AppDbContext context,IMediator mediator)
            {
                this.mapper = mapper;
                this.context = context;
                this.mediator = mediator;
            }
            public async Task<Game> Handle(AddGameRequest request, CancellationToken cancellationToken)
            {
                var result = mapper.Map<Game>(request);

                var added = context.Games.Add(result).Entity;

                await mediator.Publish(new AddedGameEvent { Id = added.Id });


                return added;
            }
        }

    }
}
