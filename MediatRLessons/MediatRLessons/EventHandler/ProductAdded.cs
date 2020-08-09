using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRLessons.EventHandler
{
    public class ProductAdded : INotification
    {
        public int Id { get; set; }
    }
    public class ProductAddedHandler : INotificationHandler<ProductAdded>
    {
        public async Task Handle(ProductAdded notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("ProductAddedd");
        }
    }
}
