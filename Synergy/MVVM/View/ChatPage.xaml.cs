using CommunityToolkit.Maui.Core.Extensions;
using Synergy.MVVM.Model;
using Synergy.MVVM.ViewModel;

namespace Synergy.MVVM.View;

public partial class ChatPage : ContentPage
{
	AppVM vm;
	public ChatPage()
	{
		InitializeComponent();
		BindingContext = vm = MauiProgram.VM;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        vm.Messages = vm.Messages.Prepend(new Message()
		{
			Sender = 2,
			Content = Entry1.Text
		}).ToObservableCollection();
		Entry1.Text = string.Empty;
		await Task.Delay(3000);
		vm.Messages = vm.Messages.Prepend(new Message()
		{
			Sender = 0,
			Content = vm.Messages[0].Content
		}).ToObservableCollection();
    }
}