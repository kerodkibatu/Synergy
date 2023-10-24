using CommunityToolkit.Mvvm.ComponentModel;

namespace Synergy.MVVM.Model;

public partial class User : ObservableObject
{
    [ObservableProperty]
    string userId;
    [ObservableProperty]
    ChatLog chatlog;
    [ObservableProperty]
    string profileId;
}
