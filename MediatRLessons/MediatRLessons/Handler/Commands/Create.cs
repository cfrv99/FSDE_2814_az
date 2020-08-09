using MediatR;
using MediatRLessons.Entites;
using MediatRLessons.EventHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRLessons.Handler.Commands
{
    public class Create
    {
        public class AddProduct : IRequest<Product>
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


        public class AddProductHandler : IRequestHandler<AddProduct, Product>
        {
            private readonly IMediator mediator;

            public AddProductHandler(IMediator mediator)
            {
                this.mediator = mediator;
            }
            public async Task<Product> Handle(AddProduct request, CancellationToken cancellationToken)
            {


                //////////////////
                await mediator.Publish(new ProductAdded { Id=5 });

                return new Product() { Id = 5 };
            }
        }
    }
}
