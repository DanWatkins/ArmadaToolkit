using ArmadaToolkit.Client.Tablet.Models;
using Xamarin.Forms;

namespace ArmadaToolkit.Client.Tablet.Views
{
    public partial class ShipEditView : ContentView
    {
        public ShipEditView()
        {
            InitializeComponent();

            BindingContext = new Ship
            {
                Title = "Imperial Class I Star Destroyer"
            };
        }
    }
}