using Synergy.MVVM.ViewModel;

namespace Synergy.MVVM.View;

public partial class TrendPage : ContentPage
{
	public TrendPage()
	{
		InitializeComponent();
		BindingContext = new AppVM();
	}
}