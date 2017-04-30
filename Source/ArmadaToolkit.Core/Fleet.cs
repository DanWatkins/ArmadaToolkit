using System.Collections.Generic;

namespace ArmadaToolkit.Core
{
    public class Fleet
    {
        public string Name { get; set; }

        public string Allegiance { get; set; }

        public int PointsTotal { get; set; }
        
        public int PointsMax { get; set; }

        public List<Ship> Ships { get; set; }
    }
}