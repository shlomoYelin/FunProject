using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Domain.SignalR
{
    public interface IChatHub
    {
        Task SendMsg(string message);
    }
}
