using Synergy.MVVM.ViewModel;

namespace Synergy.MVVM.View;

public partial class EventsPage : ContentPage
{
	public EventsPage()
	{
		InitializeComponent();
		BindingContext = new AppVM();
	}
}