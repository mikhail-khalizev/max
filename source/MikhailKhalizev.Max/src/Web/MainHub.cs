using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json.Linq;

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

        private RawProgramMain _rawProgramMain;

        public MainHub(RawProgramMain rawProgramMain)
        {
            _rawProgramMain = rawProgramMain;
        }

        public override Task OnConnectedAsync(){
            return Clients.Caller.SendAsync(
                MainHub.ClientUpdateImage,
                _rawProgramMain.DosInterrupt.PngBytes == null ? null : MainController.GetImageUrl());
        }

        public void MouseEvent(JObject obj)
        {
            // NonBlockingConsole.WriteLine($"MouseEvent: {obj}");

            var x = obj["x"]?.Value<int>();
            var y = obj["y"]?.Value<int>();
            var buttons = obj["buttons"]?.Value<int>();

            if (x != null)
                _rawProgramMain.DosInterrupt.MouseX = x.Value;
            if (y != null)
                _rawProgramMain.DosInterrupt.MouseY = y.Value;
            if (buttons != null)
            {
                _rawProgramMain.DosInterrupt.MouseLeftButton = (buttons.Value & 1) != 0;
                _rawProgramMain.DosInterrupt.MouseRightButton = (buttons.Value & 2) != 0;
            }
        }

        public void KeyboardEvent(JObject obj)
        {
            NonBlockingConsole.WriteLine($"KeyboardEvent: {obj}");

            var key = obj["key"]?.Value<string>();
            if (key == "Escape")
            {
                _rawProgramMain.DosPort.key_pressed = DosPort.kbd_keys.esc;
                _rawProgramMain.DosPic.activate_irq(1);
            }
        }
    }
}