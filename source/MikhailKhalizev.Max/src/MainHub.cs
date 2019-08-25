using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

namespace MikhailKhalizev.Max
{
    public class MainHub : Hub
    {
        private static string ClientUpdateImage => "UpdateImage";

        public static Task SendClientUpdateImage(IServiceProvider serviceProvider)
        {
            var hc = serviceProvider.GetRequiredService<IHubContext<MainHub>>();
            return hc.Clients.All.SendAsync(MainHub.ClientUpdateImage, MainController.GetImageUrl());
        }

        public override Task OnConnectedAsync(){
            return Clients.Caller.SendAsync(MainHub.ClientUpdateImage, MainController.GetImageUrl());
        }
    }
}