using CommunityToolkit.Mvvm.ComponentModel;
namespace Synergy.MVVM.Model;
public partial class ChatLog : ObservableObject
{
    [ObservableProperty]
    string belongsToUserId;
    [ObservableProperty]
    List<string> chats;
}
