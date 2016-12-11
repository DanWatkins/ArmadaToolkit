using System;
using Eto;
using Eto.Forms;

namespace ArmadaToolkit.Client.Desktop.Windows
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Platforms.Wpf).Run(new MainForm());
        }
    }
}
