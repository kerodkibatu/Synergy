using CommunityToolkit.Mvvm.ComponentModel;

namespace Synergy.MVVM.Model;
public partial class Profile : ObservableObject
{
    [ObservableProperty]
    string profileId;
    [ObservableProperty]
    string userName;
    [ObservableProperty]
    string bio;
    [ObservableProperty]
    List<string> interests;
}
