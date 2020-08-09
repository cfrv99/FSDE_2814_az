using FootballScore.Entities;
using FootballScore.Events;
using FootballScore.Hubs;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FootballScore.EventHandler
{
    public class AddedGameHandler : INotificationHandler<AddedGameEvent>
    {
        private readonly IHubContext<NotifyHub> hubContext;
        private readonly AppDbContext context;

        public AddedGameHandler(IHubContext<NotifyHub> hubContext,AppDbContext context)
        {
            this.hubContext = hubContext;
            this.context = context;
        }
        public async Task Handle(AddedGameEvent notification, CancellationToken cancellationToken)
        {
            var data = context.Games.FirstOrDefault(i => i.Id == notification.Id);
            await hubContext.Clients.All.SendAsync("Added",data);
        }
    }
}
