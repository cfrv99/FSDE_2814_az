using MediatR;
using MediatRLessons.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRLessons.Handler.Queries
{
    public class List
    {
        public class GetAllProducts : IRequest<List<Product>>
        {

        }

        public class GetAllProductHandler : IRequestHandler<GetAllProducts, List<Product>>
        {
            public async Task<List<Product>> Handle(GetAllProducts request, CancellationToken cancellationToken)
            {
                return new List<Product>() { new Product { Id = 5 } };
            }
        }
    }
}
