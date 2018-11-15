using System.Runtime.InteropServices;
using System.Windows.Media;
using CSDeskBand;
using CSDeskBand.Wpf;
using Size = CSDeskBand.Size;

namespace Cafemoca.TaskBarAnalogClock.Views
{
    /// <summary>
    /// Interaction logic for AnalogClock.xaml
    /// </summary>
    [ComVisible(true)]
    [Guid("7FCA3F58-7F05-40AC-82DE-649CA79CBD11")]
    [CSDeskBandRegistration(Name = "TaskBar Analog Clock", ShowDeskBand = true)]
    public partial class AnalogClock : CSDeskBandWpf
    {
        public AnalogClock()
        {
            this.InitializeComponent();

            this.Options.MinHorizontalSize = new Size(40, 40);
            this.Options.HorizontalSize = new Size(40, 40);
            this.Options.MaxHorizontalHeight = 40;
            this.Options.MinVerticalSize = new Size(40, 40);
            this.Options.VerticalSize = new Size(40, 40);
            this.Options.MaxVerticalWidth = 40;
            this.Options.Title = "TaskBar Analog Clock";
            this.Options.ShowTitle = false;
            this.Options.IsFixed = true;
            this.Options.HeightIncrement = 1;
            this.Options.HeightCanChange = false;
            this.TransparencyEnabled = true;
            this.TransparencyColorKey = Color.FromRgb(128, 128, 128);
        }
    }
}
