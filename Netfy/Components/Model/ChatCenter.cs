namespace Netfy.Components.Model
{
    public class ChatCenter
    {
        public static List<Chat> ChatList = new List<Chat>();


        public static void AddChat(Chat chat)
        {
            var MaxID = ChatList.Max(x=>x.chatID);
            chat.chatID=MaxID+1;
            ChatList.Add(chat);
        }


    }
}