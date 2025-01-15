


using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Netfy.Components.Model;

namespace Netfy.StateStore
{
public class SessionStorage
{
    private readonly ProtectedSessionStorage protectedSessionStorage;
    public SessionStorage(ProtectedSessionStorage protectedSessionStorage)
    {
        this.protectedSessionStorage=protectedSessionStorage;

    }
    public async Task <User?> getUserInfo()
    {
        var result = await this.protectedSessionStorage.GetAsync<User>("user");
        if(result.Success) return result.Value;
        else return null;
    }
    public async Task SetUserInfor(User user)
    {
        await this.protectedSessionStorage.SetAsync("user",user);
    }
}


}