using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Synergy.MVVM.Model;

public partial class Chat : ObservableObject
{
    [ObservableProperty]
    string chatId;
    [ObservableProperty]
    ObservableCollection<Message> messages;
}
public partial class Message : ObservableObject
{
    [ObservableProperty]
    int sender;
    [ObservableProperty]
    string content;
}
