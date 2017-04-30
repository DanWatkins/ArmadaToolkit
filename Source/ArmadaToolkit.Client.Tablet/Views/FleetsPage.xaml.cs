using ArmadaToolkit.Client.Tablet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmadaToolkit.Client.Tablet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FleetsPage : ContentPage
    {
        public FleetsPage()
        {
            InitializeComponent();
            BindingContext = new FleetsPageViewModel();
        }

        private void ToolbarItemNew_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FleetBuilderPage());
        }
    }
}