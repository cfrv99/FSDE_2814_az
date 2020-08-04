using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRStep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRStep.Hubs
{
    //[Authorize(Roles ="Admin")]
    public class ChatHub : Hub<IHubService>
    {
        public ChatHub(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        static List<string> ConncetionIds = new List<string>();
        static public Dictionary<string,string> ConnectedAdmins= new Dictionary<string,string>();
        private readonly UserManager<AppUser> userManager;

        public override async Task OnConnectedAsync()
        {

            Thread.Sleep(3000000);
            var name = Context.User.Identity.Name;
            //var UserId = Context.User.FindFirst(i => i.Type == ClaimTypes.NameIdentifier).Value;

            
            //var user = await userManager.GetUserAsync(Context.User);

            var user = await userManager.FindByNameAsync(name);

            user.ConnectionId = Context.ConnectionId;

            ConnectedAdmins.Add(Context.ConnectionId, user.Id.ToString());
            var id = Context.ConnectionId;
            ConncetionIds.Add(Context.ConnectionId);
            //await Clients.All.SendAsync("Connected",$"{Context.ConnectionId} this user connected to server");
            await Clients.All.Connected("Salam");
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            Thread.Sleep(5000);
            var user = await userManager.GetUserAsync(Context.User);
            user.ConnectionId = string.Empty;
            ConncetionIds.Remove(Context.ConnectionId);

        }

        public async Task SendMessage(string message)
        {
            //await Clients.All.SendAsync("ReceiveMessage",message);
            await Clients.All.ReceiveMessage(message);
        }


        public async Task Subscribe(string groupName="Hello")
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

        } 

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendMessageToGroup(string groupName)
        {     

            await Clients.Group(groupName).SendMessage("SalamDostlar :D","Mehemmed Deniz");
        }

        

        public async Task SendAllAdminNotfy(string message)
        {
            foreach (var (key,value) in ConnectedAdmins)
            {
                await Clients.Client(key).SendMessage("Salam", "Filankes");
                await Clients.User(value).SendMessage("", "");
            }
        }

        public async Task AllNotifyChange()
        {
            await Clients.All.SendMessage("", "");
        }
    }
} /// 2 , 5 , 10 , 20
