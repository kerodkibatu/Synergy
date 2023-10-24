using Synergy.MVVM.ViewModel;

namespace Synergy.MVVM.View;
public partial class BasePage : FlyoutPage
{
    public BasePage()
    {
        InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
    }

    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is FlyoutPageItem item)
        {
            if(MauiProgram.VM.Address==MauiProgram.VM.Address1)
                MauiProgram.VM.Address = MauiProgram.VM.Address2;
            else
                MauiProgram.VM.Address = MauiProgram.VM.Address1;
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                IsPresented = false;
            
        }
    }
}