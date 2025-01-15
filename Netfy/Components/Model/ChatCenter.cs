namespace Netfy.Components.Model
{
    public class ChatCenter
    {
        public static List<Chat> ChatList = new List<Chat>();


        public static void AddChat(Chat chat)
        {
          
            ChatList.Add(chat);
        }


    }
}