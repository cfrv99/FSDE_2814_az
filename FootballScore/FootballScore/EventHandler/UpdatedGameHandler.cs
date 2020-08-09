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
    public class UpdatedGameHandler : INotificationHandler<EditedGameEvent>
    {
        private readonly IHubContext<NotifyHub> hubContext;

        public UpdatedGameHandler(IHubContext<NotifyHub> hubContext)
        {
            this.hubContext = hubContext;
        }
        public async Task Handle(EditedGameEvent notification, CancellationToken cancellationToken)
        {
            await hubContext.Clients.All.SendAsync("Edited");         
        }
    }
}
