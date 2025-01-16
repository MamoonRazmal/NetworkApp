using Microsoft.AspNetCore.SignalR;
using Netfy.Components.Model;
public class ChatHub: Hub
{
    private static readonly List<User> LoggedInUsers =new();

public async Task addUser(User user)
{
    if(!LoggedInUsers.Any(u=>u.username ==user.username))
    {
         LoggedInUsers.Add(user);
         await Clients.All.SendAsync("RecievedList",LoggedInUsers);
    }
   
}

public async Task sendMessage(string user,string message)
{
    await Clients.All.SendAsync("ReceiveMessage",user,message);

}
public async Task sendUserList(List<User> userlist)
{
    await Clients.All.SendAsync("RecievedListq",userlist);
}

}