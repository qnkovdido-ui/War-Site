namespace Nazi.Models
{
    public class Tanks
    {
            public int Id { get; set; }
            public string? Brand { get; set; }
            public string? Model { get; set; }

            public double Weight { get; set; }
            public int CrewSize { get; set; }

            public double Reliability { get; set; }
            public bool Autoloader { get; set; }

            public bool ThermalVision { get; set; }
            public bool NightVision { get; set; }

            public double MainGunCaliber { get; set; }
            public double ReloadSpeed { get; set; }
            public double Accuracy { get; set; }
            public double TurretRotationSpeed { get; set; }

            public double FrontPlateArmorThickness { get; set; }
            public double SideArmorThickness { get; set; }
            public double HullArmorThickness { get; set; }
            public double RearArmorThickness { get; set; }

             public double TopSpeed { get; set; }
            public double FuelConsumption { get; set; }
            public double EnginePower { get; set; }

            public string? ImageUrl { get; set; }

            public bool IsActive { get; set; } = true;
            public double WhenMade { get; set; }
            public string Country { get; set; }
    }
}