using Eto.Forms;
using Eto.Serialization.Xaml;

namespace ArmadaToolkit.Client.Desktop
{
    public class MainForm : Form
    {
        public MainForm()
        {
            XamlReader.Load(this);
        }
    }
}
