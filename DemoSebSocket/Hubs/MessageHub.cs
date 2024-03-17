using DemoSebSocket.Forms;
using Microsoft.AspNetCore.SignalR;

namespace DemoSebSocket.Hubs
{
    public class MessageHub: Hub
    {
        public async Task SendMessage(MessageForm form)
        {
            await Clients.Others.SendAsync("newMessage", new
            {
                Author = form.Author,
                Content = form.Content,
                Date = DateTime.Now,
            });
        }
    }
}
