using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballScore.Hubs
{
    public class NotifyHub:Hub
    {
        static public List<string> connectionIds = new List<string>();

        public override Task OnConnectedAsync()
        {
            connectionIds.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            connectionIds.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

        
    }
}
