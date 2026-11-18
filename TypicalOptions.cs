using System;
using System.Collections.Generic;
using System.Text;

namespace zadania_5_24832
{
    internal class VesselOption
    {
        public string Name { get; }
        public double CapacityMl { get; }
        public string DisplayName => $"{Name} ({CapacityMl:0.##} ml)";

        public VesselOption(string name, double capacityMl)
        {
            Name = name;
            CapacityMl = capacityMl;
        }
    }

    internal class SolutionOption
    {
        public string Name { get; }
        public double Percent { get; }
        public string DisplayName => $"{Name} ({Percent:0.##}%)";

        public SolutionOption(string name, double percent)
        {
            Name = name;
            Percent = percent;
        }
    }

    internal static class TypicalOptions
    {
        public static readonly VesselOption[] Vessels =
        {
            new VesselOption("Kieliszek", 50),
            new VesselOption("Szklanka", 250),
            new VesselOption("Kubek", 300),
            new VesselOption("Butelka", 500),
            new VesselOption("Butelka", 1000)
        };

        public static readonly SolutionOption[] Solutions =
        {
            new SolutionOption("Woda", 0),
            new SolutionOption("Roztwór", 5),
            new SolutionOption("Roztwór", 10),
            new SolutionOption("Roztwór", 20),
            new SolutionOption("Roztwór", 40),
            new SolutionOption("Roztwór", 70),
            new SolutionOption("Roztwór", 96)
        };
    }
}
