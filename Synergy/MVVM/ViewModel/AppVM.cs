using CommunityToolkit.Mvvm.ComponentModel;
using Synergy.MVVM.Model;
using System.Collections.ObjectModel;

namespace Synergy.MVVM.ViewModel;
public partial class AppVM : ObservableObject
{
    [ObservableProperty]
    string address = "http://192.168.0.30:5000/video_feed_own";
    [ObservableProperty]
    string address1 = "http://192.168.0.30:5000/video_feed_own";
    [ObservableProperty]
    string address2 = "http://192.168.0.33:5000/video_feed_own";
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    public bool IsNotBusy => !IsBusy;
    [ObservableProperty]
    ObservableCollection<Event> featuredEvents = new()
    {
        new Event() { Name = "Yeabsra", Hoster = "TechHub Ethiopia", Address = "Addis Ababa Exhibition Center", Date = DateTime.Parse("2023-11-15"), Participants = 300 },
        new Event() { Name = "Ethiopian Innovation Expo", Hoster = "TechHub Ethiopia", Address = "Addis Ababa Exhibition Center", Date = DateTime.Parse("2023-11-15"), Participants = 300 },
        new Event() { Name = "Abyssinian Music Festival", Hoster = "EthioSounds", Address = "Lalibela Park", Date = DateTime.Parse("2023-12-10"), Participants = 1000 },
        new Event() { Name = "Coffee Culture Workshop", Hoster = "EthioBeans", Address = "National Coffee Research Center", Date = DateTime.Parse("2023-10-30"), Participants = 50 },
    };
    [ObservableProperty]
    ObservableCollection<Event> upComingEvents = new()
    {
        new Event() { Name = "EthioTech Summit", Hoster = "Tech Ethiopia", Address = "Sheraton Addis", Date = DateTime.Parse("2023-11-20"), Participants = 500 },
        new Event() { Name = "African Artisans Fair", Hoster = "African Crafts Collective", Address = "Addis Ababa Arts Village", Date = DateTime.Parse("2023-11-25"), Participants = 200 },
        new Event() { Name = "Omo Valley Photography Workshop", Hoster = "LensCrafters Collective", Address = "Jinka, Omo Valley", Date = DateTime.Parse("2023-12-05"), Participants = 20 },
        new Event() { Name = "Dashen Beer Fest", Hoster = "Dashen Brewery", Address = "Meskel Square", Date = DateTime.Parse("2023-11-10"), Participants = 800 },
        new Event() { Name = "Bale Mountains Eco-tourism Symposium", Hoster = "Green Ethiopia Foundation", Address = "Bale Mountains National Park", Date = DateTime.Parse("2023-12-15"), Participants = 100 }
    };
    [ObservableProperty]
    ObservableCollection<Event> ongoingEvents = new()
    {
        new Event() { Name = "BITS College Hackathon", Hoster = "BITS College", Address = "Bits College 4th Floor", Date = DateTime.Today.AddDays(-1), Participants = 40},
        new Event() { Name = "Innovate Addis Startup Pitch", Hoster = "Innovate Addis", Address = "BlueMoon Coworking Space", Date = DateTime.Parse("2023-11-05"), Participants = 75 },
        new Event() { Name = "Simien Mountains Trekking Expedition", Hoster = "Explore Ethiopia Tours", Address = "Simien Mountains National Park", Date = DateTime.Parse("2023-12-01"), Participants = 30 },
    };
    [ObservableProperty]
    ObservableCollection<Message> messages = new()
    {

    };
        [ObservableProperty]
    ObservableCollection<string> trends = new()
    {
        "Sports",
    "Coding",
    "Traveling",
    "Reading",
    "Cooking",
    "Gaming",
    "Photography",
    "Music",
    "Drawing",
    "Hiking",
    "Yoga",
    "Meditation",
    "Movies",
    "Dancing",
    "Writing",
    "Painting",
    "Gardening",
    "Singing",
    "Biking",
    "Swimming",
    "History",
    "Science",
    "Technology",
    "Fashion",
    "Camping",
    "Fishing",
    "Crafting",
    "Languages",
    "Animals",
    "Fitness"
    };
}
