using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmadaToolkit.Client.Tablet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public MainPageMaster()
        {
            InitializeComponent();
            BindingContext = new MainPageMasterViewModel();
        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMenuItem> MenuItems { get; }

            public MainPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
                {
                    new MainPageMenuItem { Id = 1, Title = "Fleets" },
                    new MainPageMenuItem { Id = 2, Title = "Ships" },
                    new MainPageMenuItem { Id = 3, Title = "Squadrons" },
                    new MainPageMenuItem { Id = 4, Title = "Upgrades" },
                    new MainPageMenuItem { Id = 5, Title = "Objectives" },
                    new MainPageMenuItem { Id = 7, Title = "Where to Buy" },
                    new MainPageMenuItem { Id = 8, Title = "Where to Play" },
                    new MainPageMenuItem { Id = 6, Title = "Account" },
                    new MainPageMenuItem { Id = 3, Title = "About" }
                });
            }

            public event PropertyChangedEventHandler PropertyChanged;

            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
