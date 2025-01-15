namespace Netfy.Components.Model
{
    public class GroupRepo
    {
        public static List<ChatGroupObject> AllGroup = new List<ChatGroupObject>()
        {
            new ChatGroupObject{ groupId=1,groupname="Coding",description="This is Coding Space.just login if you dare"},
            new ChatGroupObject{ groupId=2,groupname="Food",description="Come to Food World"},
            new ChatGroupObject{ groupId=3,groupname="Sport",description="Come and challenge your skills"}
        };
        public static List<ChatGroupObject> getgroupinfo() => AllGroup;
        public static ChatGroupObject getGroupInfoById(int id)
        {
            ChatGroupObject? foundGroup = AllGroup.FirstOrDefault(x => x.groupId == id);
            if (foundGroup is not null)
            {
                return new ChatGroupObject
                {
                    groupId = foundGroup.groupId,
                    groupname = foundGroup.groupname,
                    groupdescription = foundGroup.description
                };
            }
            return null;
        }
    }

}
