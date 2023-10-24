namespace Synergy.MVVM.View;

public partial class ChatlogPage : ContentPage
{
	public ChatlogPage()
	{
		InitializeComponent();
		BindingContext = MauiProgram.VM;
	}
}