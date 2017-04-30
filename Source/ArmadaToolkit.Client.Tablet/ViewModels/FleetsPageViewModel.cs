using ArmadaToolkit.Core;
using System.Collections.Generic;

namespace ArmadaToolkit.Client.Tablet.ViewModels
{
    public class FleetsPageViewModel
    {
        public List<Fleet> Fleets { get; }

        public FleetsPageViewModel()
        {
            const string allegianceRebels = "Rebels";
            const string allegianceEmpire = "Empire";

            Fleets = new List<Fleet>
            {
                new Fleet
                {
                    Allegiance = allegianceEmpire,
                    Name = "VSD Carriers",
                    PointsMax = 400,
                    PointsTotal = 400
                },
                new Fleet
                {
                    Allegiance = allegianceEmpire,
                    Name = "You may fire when ready",
                    PointsMax = 1250,
                    PointsTotal = 1245
                },
                new Fleet
                {
                    Allegiance = allegianceRebels,
                    Name = "April 11",
                    PointsMax = 400,
                    PointsTotal = 399
                },
                new Fleet
                {
                    Allegiance = allegianceEmpire,
                    Name = "Regionals 2017",
                    PointsMax = 400,
                    PointsTotal = 397
                },
                new Fleet
                {
                    Allegiance = allegianceRebels,
                    Name = "Aloha Ackbar",
                    PointsMax = 400,
                    PointsTotal = 399
                },
                new Fleet
                {
                    Allegiance = allegianceRebels,
                    Name = "Home 5",
                    PointsMax = 500,
                    PointsTotal = 495
                }
            };
        }
    }
}