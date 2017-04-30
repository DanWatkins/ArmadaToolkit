using System.Collections.Generic;
using Xamarin.Forms;

namespace ArmadaToolkit.Client.Tablet.Models
{
    public class Fleet
    {
        public string Name { get; set; }

        public string Allegiance { get; set; }

        public int PointsTotal { get; set; }
        
        public int PointsMax { get; set; }

        public List<Ship> Ships { get; set; }

        public ImageSource AllegianceImageSource
        {
            get
            {
                return ImageSource.FromResource($"ArmadaToolkit.Client.Tablet.Images.{Allegiance}.png");
            }
        }

        public string PointsFormatted => $"{PointsTotal}/{PointsMax}";
    }
}