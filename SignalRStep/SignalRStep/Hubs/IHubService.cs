using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRStep.Hubs
{
    public interface IHubService
    {
        Task Connected(string message);
        Task ReceiveMessage(string message);
        Task SendMessage(string message, string nickName);
    }
}
