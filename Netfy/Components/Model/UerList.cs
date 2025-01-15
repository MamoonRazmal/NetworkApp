namespace Netfy.Components.Model
{
    public class UserList
    {
        public static List<User> userList = new List<User>()
        {
            new User{}
        };
        public static List<User> RegistedUserList = new List<User>()
        {
            new User{ UserId=1,password="1234",username="Kemosabi"},
             new User{ UserId=2,password="1234",username="007"},
        };

        public static void addUser(User user)
        {
            int getUserId = userList.Max(x=>x.UserId);
            if(getUserId ==0)
            {
                user.UserId=1;
            }
            else{
                user.UserId=getUserId+1;
            }
            userList.Add(user);
        }
        public static List<User> getRegistedUsers=>RegistedUserList;
        public static bool checkUsername(string? username)
        {
           return  RegistedUserList.Any(user=>user.username.Equals(username,StringComparison.OrdinalIgnoreCase));
            
        }
        public static bool checkPassword(string password)
        {
            return RegistedUserList.Any(pass=>pass.password.Equals(password,StringComparison.OrdinalIgnoreCase));
        }
    }
}