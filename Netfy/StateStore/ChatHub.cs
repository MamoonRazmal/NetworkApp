using Microsoft.AspNetCore.SignalR;
public class ChatHub: Hub
{
public async Task sendMessage(string user,string message)
{
    await Clients.All.SendAsync("ReceiveMessage",user,message);

}

}