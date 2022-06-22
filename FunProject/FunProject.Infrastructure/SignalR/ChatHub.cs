using FunProject.Domain.SignalR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.SignalR
{
    public class ChatHub : Hub, IChatHub
    {
        public async Task SendMsg(string message)
        {
             await Clients.All.SendAsync("sendmsg", message);
        }
    }
}
