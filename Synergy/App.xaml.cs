using Synergy.MVVM.View;

namespace Synergy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BasePage();
        }
    }
}