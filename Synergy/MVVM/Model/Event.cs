using CommunityToolkit.Mvvm.ComponentModel;

namespace Synergy.MVVM.Model;

public partial class Event : ObservableObject
{
    [ObservableProperty]
    string name;
    [ObservableProperty]
    string address;
    [ObservableProperty]
    string hoster;
    [ObservableProperty]
    string[] targetInterests;
    [ObservableProperty]
    DateTime date;
    [ObservableProperty]
    int participants;
}