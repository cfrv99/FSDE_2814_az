using FootballScore.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballScore.Queries
{
    public class All
    {
        public class GetAllRequest : IRequest<List<Game>>
        {

        }
        public class GetAllHandler : IRequestHandler<GetAllRequest, List<Game>>
        {
            private readonly AppDbContext context;

            public GetAllHandler(AppDbContext context)
            {
                this.context = context;
            }
            public Task<List<Game>> Handle(GetAllRequest request, CancellationToken cancellationToken)
            {
                var result = context.Games.ToList();
                return Task.FromResult(result);
            }
        }
    }
}