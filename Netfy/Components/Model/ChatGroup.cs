namespace Netfy.Components.Model

{
public class ChatGroup
{
    public static List<string> GroupName = new List<string>()
    {
        "Coding","Food","Sport"
    };

    public static List<string>groupPic = new List<string>()
    {
        "\\Images\\Sport.jpg", "\\Images\\Food.jpg", "\\Images\\Coding.jpg"
    };

    public static List<string> GetGroupName()=>GroupName;
    public static List<string>GetGroupPhoto()=>groupPic;
}



}
