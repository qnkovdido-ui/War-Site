using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nazi.Models;

namespace Nazi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<AirPlane> airplaneList = new List<AirPlane>();

            AirPlane EuroFighterTyphoon = new AirPlane()
            {
                id = 1,
                brand = "Eurofighter Jagdflugzeug GmbH",
                model = "EF2000",
                Maxspeed = 2495,
                FirstFlightSate = new DateTime(1994, 3, 4),
                IsActive = true,
                ImageUrl = "/Pic/EurofighterTyphoon.jpg"
            };

            AirPlane F22= new AirPlane()
            {
                id = 2,
                brand = "Lockheed Martin",
                model = "F-22 Raptor",
                Maxspeed = 2410,
                FirstFlightSate = new DateTime(1997, 9, 7),
                IsActive = true,
                ImageUrl = "/Pic/F22.jpg"
            };

            AirPlane Su57 = new AirPlane()
            {
                id = 3,
                brand = "Sukhoi",
                model = "Su-57",
                Maxspeed = 2600,
                FirstFlightSate = new DateTime(2010, 1, 29),
                IsActive = true,
                ImageUrl = "/Pic/Su57.jpg"
            };

            AirPlane F35 = new AirPlane()
            {
                id = 4,
                brand = "Lockheed Martin",
                model = "F-35 Lightning II",
                Maxspeed = 1930,
                FirstFlightSate = new DateTime(2006, 12, 15),
                IsActive = true,
                ImageUrl = "/Pic/F35.jpg"
            };
            
            AirPlane Rafale = new AirPlane()
            {
                id = 5,
                brand = "Dassault Aviation",
                model = "Rafale",
                Maxspeed = 1912,
                FirstFlightSate = new DateTime(1986, 7, 4),
                IsActive = true,
                ImageUrl = "/Pic/Rafale.jpg"
            };

            AirPlane Mig29 = new AirPlane()
            {
                id = 6,
                brand = "Mikoyan",
                model = "MiG-29",
                Maxspeed = 2450,
                FirstFlightSate = new DateTime(1977, 10, 6),
                IsActive = true,
                ImageUrl = "/Pic/Mig29.jpg"
            };

            AirPlane Mig31 = new AirPlane()
            {
                id = 7,
                brand = "Mikoyan",
                model = "MiG-31",
                Maxspeed = 3000,
                FirstFlightSate = new DateTime(1975, 9, 16),
                IsActive = true,
                ImageUrl = "/Pic/Mig31.jpg"
            };

            AirPlane F16 = new AirPlane()
            {
                id = 8,
                brand = "General Dynamics",
                model = "F-16 Fighting Falcon",
                Maxspeed = 2120,
                FirstFlightSate = new DateTime(1974, 2, 2),
                IsActive = true,
                ImageUrl = "/Pic/F16.jpg"
            };
            AirPlane J20 = new AirPlane()
            {
                id = 9,
                brand = "Chengdu Aerospace Corporation",
                model = "J-20 Mighty Dragon",
                Maxspeed = 2100,
                FirstFlightSate = new DateTime(2011, 1, 11),
                IsActive = true,
                ImageUrl = "/Pic/J20.jpg"
            };
            AirPlane Gripen = new AirPlane()
            {
                id = 10,
                brand = "Saab AB",
                model = "JAS 39 Gripen",
                Maxspeed = 2200,
                FirstFlightSate = new DateTime(1988, 12, 9),
                IsActive = true,
                ImageUrl = "/Pic/Gripen.jpg"
            };
            AirPlane F15 = new AirPlane()
            {
                id = 11,
                brand = "McDonnell Douglas",
                model = "F-15 Eagle",
                Maxspeed = 2655,
                FirstFlightSate = new DateTime(1972, 7, 27),
                IsActive = true,
                ImageUrl = "/Pic/F15.jpg"
            };

            AirPlane F18 = new AirPlane()
            {
                id = 12,
                brand = "McDonnell Douglas / Boeing",
                model = "F/A-18 Hornet",
                Maxspeed = 1915,
                FirstFlightSate = new DateTime(1978, 11, 18),
                IsActive = true,
                ImageUrl = "/Pic/F18.jpg"
            };

            AirPlane SuperHornet = new AirPlane()
            {
                id = 13,
                brand = "Boeing",
                model = "F/A-18E/F Super Hornet",
                Maxspeed = 1915,
                FirstFlightSate = new DateTime(1995, 11, 29),
                IsActive = true,
                ImageUrl = "/Pic/SuperHornet.jpg"
            };

            AirPlane F14 = new AirPlane()
            {
                id = 14,
                brand = "Grumman",
                model = "F-14 Tomcat",
                Maxspeed = 2485,
                FirstFlightSate = new DateTime(1970, 12, 21),
                IsActive = false,
                ImageUrl = "/Pic/F14.jpg"
            };

            AirPlane Mirage2000 = new AirPlane()
            {
                id = 15,
                brand = "Dassault Aviation",
                model = "Mirage 2000",
                Maxspeed = 2336,
                FirstFlightSate = new DateTime(1978, 3, 10),
                IsActive = true,
                ImageUrl = "/Pic/Mirage2000.jpg"
            };

            AirPlane MirageF1 = new AirPlane()
            {
                id = 16,
                brand = "Dassault Aviation",
                model = "Mirage F1",
                Maxspeed = 2340,
                FirstFlightSate = new DateTime(1966, 12, 23),
                IsActive = false,
                ImageUrl = "/Pic/MirageF1.jpg"
            };

            AirPlane Su27 = new AirPlane()
            { 
                id = 17,
                brand = "Sukhoi",
                model = "Su-27",
                Maxspeed = 2500,
                FirstFlightSate = new DateTime(1977, 5, 20),
                IsActive = true,
                ImageUrl = "/Pic/Su27.jpg"
            };

            AirPlane Su30 = new AirPlane()
            {
                id = 18,
                brand = "Sukhoi",
                model = "Su-30",
                Maxspeed = 2120,
                FirstFlightSate = new DateTime(1989, 12, 31),
                IsActive = true,
                ImageUrl = "/Pic/Su30.jpg"
            };

            AirPlane Su35 = new AirPlane()
            {
                id = 19,
                brand = "Sukhoi",
                model = "Su-35",
                Maxspeed = 2400,
                FirstFlightSate = new DateTime(2008, 2, 19),
                IsActive = true,
                ImageUrl = "/Pic/Su35.jpg"
            };

            AirPlane Su34 = new AirPlane()
            {
                id = 20,
                brand = "Sukhoi",
                model = "Su-34",
                Maxspeed = 1900,
                FirstFlightSate = new DateTime(1990, 4, 13),
                IsActive = true,
                ImageUrl = "/Pic/Su34.jpg"
            };

            AirPlane Mig25 = new AirPlane()
            {
                id = 21,
                brand = "Mikoyan",
                model = "MiG-25",
                Maxspeed = 3000,
                FirstFlightSate = new DateTime(1964, 3, 6),
                IsActive = false,
                ImageUrl = "/Pic/Mig25.jpg"
            };

            AirPlane Mig35 = new AirPlane()
            {
                id = 22,
                brand = "Mikoyan",
                model = "MiG-35",
                Maxspeed = 2400,
                FirstFlightSate = new DateTime(2007, 2, 6),
                IsActive = true,
                ImageUrl = "/Pic/Mig35.jpg"
            };

            AirPlane J10 = new AirPlane()
            {
                id = 23,
                brand = "Chengdu Aerospace Corporation",
                model = "J-10",
                Maxspeed = 2200,
                FirstFlightSate = new DateTime(1998, 3, 23),
                IsActive = true,
                ImageUrl = "/Pic/J10.jpg"
            };

            AirPlane JF17 = new AirPlane()
            {
                id = 24,
                brand = "Chengdu / Pakistan Aeronautical Complex",
                model = "JF-17 Thunder",
                Maxspeed = 1910,
                FirstFlightSate = new DateTime(2003, 8, 25),
                IsActive = true,
                ImageUrl = "/Pic/JF17.jpg"
            };

            AirPlane Tejas = new AirPlane()
            {
                id = 25,
                brand = "HAL",
                model = "HAL Tejas",
                Maxspeed = 2205,
                FirstFlightSate = new DateTime(2001, 1, 4),
                IsActive = true,
                ImageUrl = "/Pic/Tejas.jpg"
            };
            AirPlane B2 = new AirPlane()
            {
                id = 26,
                brand = "Northrop Grumman",
                model = "B-2 Spirit",
                Maxspeed = 1010,
                FirstFlightSate = new DateTime(1989, 7, 17),
                IsActive = true,
                ImageUrl = "/Pic/B2.jpg"
            };

            AirPlane B1 = new AirPlane()
            {
                id = 27,
                brand = "Rockwell International / Boeing",
                model = "B-1B Lancer",
                Maxspeed = 1335,
                FirstFlightSate = new DateTime(1974, 12, 23),
                IsActive = true,
                ImageUrl = "/Pic/B1.jpg"
            };
            AirPlane Rafale = new AirPlane()
            {
                id = 5,
                brand = "Dassault Aviation",
                model = "Rafale",
                Maxspeed = 1912,
                FirstFlightSate = new DateTime(1986, 7, 4),
                IsActive = true,
                ImageUrl = "/Pic/Rafale.jpg"
            };
            AirPlane Su57 = new AirPlane()
            {
                id = 3,
                brand = "Sukhoi",
                model = "Su-57",
                Maxspeed = 2600,
                FirstFlightSate = new DateTime(2010, 1, 29),
                IsActive = true,
                ImageUrl = "/Pic/Su57.jpg"
            };

            AirPlane[] airPlanes =
{ EuroFighterTyphoon, F22, Su57, F35, Rafale, Mig29, Mig31, F16, J20, Gripen, F15, F18, SuperHornet, F14, Mirage2000, MirageF1, Su27, Su30,Su35, Su34, Su57 ,Mig25, Mig35,J10, JF17,Tejas,B2,B1};

            ViewBag.AirPlanes = airPlanes;




            airplaneList.Add(EuroFighterTyphoon);
            airplaneList.Add(F22);
            airplaneList.Add(Su57);
            airplaneList.Add(F35);
            airplaneList.Add(Rafale);
            airplaneList.Add(Mig29);
            airplaneList.Add(Mig31);
            airplaneList.Add(F16);
            airplaneList.Add(J20);
            airplaneList.Add(Gripen);
            airplaneList.Add(F15);
            airplaneList.Add(F18);
            airplaneList.Add(SuperHornet);
            airplaneList.Add(F14);
            airplaneList.Add(Mirage2000);
            airplaneList.Add(MirageF1);
            airplaneList.Add(Su27);
            airplaneList.Add(Su30);
            airplaneList.Add(Su35);
            airplaneList.Add(Su34);
            airplaneList.Add(Mig25);
            airplaneList.Add(Mig35);
            airplaneList.Add(J10);
            airplaneList.Add(JF17);
            airplaneList.Add(Tejas);



            return View(airplaneList);
        }

        public IActionResult Tanks()
        {
            List<Tanks> tankList = new List<Tanks>();

            Tanks Leopard2A7V = new Tanks
            {
                Id = 1,
                Brand = "Krauss-Maffei Wegmann",
                Model = "Leopard 2A7V",
                Country = "Germany",
                Weight = 63.0,
                CrewSize = 4,
                Reliability = 9.5,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 5.5,
                Accuracy = 9.5,
                TurretRotationSpeed = 30.0,
                FrontPlateArmorThickness = 950,
                SideArmorThickness = 700,
                HullArmorThickness = 800,
                RearArmorThickness = 350,
                TopSpeed = 68,
                FuelConsumption = 340,
                EnginePower = 1500,
                ImageUrl = "/Pic/Leopard2A7V.jpg",
                IsActive = true,
                WhenMade = 2019
            };

            Tanks M1A2Abrams = new Tanks
            {
                Id = 2,
                Brand = "General Dynamics",
                Model = "M1A2 Abrams",
                Country = "USA",
                Weight = 66.8,
                CrewSize = 4,
                Reliability = 9.0,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 6.0,
                Accuracy = 9.5,
                TurretRotationSpeed = 40.0,
                FrontPlateArmorThickness = 900,
                SideArmorThickness = 650,
                HullArmorThickness = 800,
                RearArmorThickness = 300,
                TopSpeed = 67,
                FuelConsumption = 500,
                EnginePower = 1500,
                ImageUrl = "/Pic/Abrams.jpg",
                IsActive = true,
                WhenMade = 1992
            };

            Tanks T90 = new Tanks
            {
                Id = 3,
                Brand = "Uralvagonzavod",
                Model = "T-90",
                Country = "Russia",
                Weight = 46.5,
                CrewSize = 3,
                Reliability = 8.5,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 125.0,
                ReloadSpeed = 6.5,
                Accuracy = 8.0,
                TurretRotationSpeed = 24.0,
                FrontPlateArmorThickness = 800,
                SideArmorThickness = 550,
                HullArmorThickness = 700,
                RearArmorThickness = 250,
                TopSpeed = 60,
                FuelConsumption = 300,
                EnginePower = 1000,
                ImageUrl = "/Pic/T90.jpg",
                IsActive = true,
                WhenMade = 1992
            };

            Tanks Challenger2 = new Tanks
            {
                Id = 4,
                Brand = "BAE Systems",
                Model = "Challenger 2",
                Country = "United Kingdom",
                Weight = 62.5,
                CrewSize = 4,
                Reliability = 9.0,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 6.5,
                Accuracy = 9.0,
                TurretRotationSpeed = 25.0,
                FrontPlateArmorThickness = 1000,
                SideArmorThickness = 700,
                HullArmorThickness = 850,
                RearArmorThickness = 350,
                TopSpeed = 59,
                FuelConsumption = 400,
                EnginePower = 1200,
                ImageUrl = "/Pic/Challenger2.jpg",
                IsActive = true,
                WhenMade = 1998
            };

            Tanks Leclerc = new Tanks
            {
                Id = 5,
                Brand = "Nexter",
                Model = "Leclerc",
                Country = "France",
                Weight = 57.4,
                CrewSize = 3,
                Reliability = 8.5,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 4.5,
                Accuracy = 9.0,
                TurretRotationSpeed = 35.0,
                FrontPlateArmorThickness = 900,
                SideArmorThickness = 650,
                HullArmorThickness = 750,
                RearArmorThickness = 300,
                TopSpeed = 72,
                FuelConsumption = 350,
                EnginePower = 1500,
                ImageUrl = "/Pic/Leclerc.jpg",
                IsActive = true,
                WhenMade = 1992
            };

            Tanks Type99 = new Tanks
            {
                Id = 6,
                Brand = "Norinco",
                Model = "Type 99",
                Country = "China",
                Weight = 54.0,
                CrewSize = 3,
                Reliability = 8.0,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 125.0,
                ReloadSpeed = 6.0,
                Accuracy = 8.5,
                TurretRotationSpeed = 30.0,
                FrontPlateArmorThickness = 850,
                SideArmorThickness = 600,
                HullArmorThickness = 750,
                RearArmorThickness = 300,
                TopSpeed = 80,
                FuelConsumption = 320,
                EnginePower = 1500,
                ImageUrl = "/Pic/Type99.jpg",
                IsActive = true,
                WhenMade = 2001
            };

            Tanks MerkavaMk4 = new Tanks
            {
                Id = 7,
                Brand = "IMI",
                Model = "Merkava Mk.4",
                Country = "Israel",
                Weight = 65.0,
                CrewSize = 4,
                Reliability = 9.5,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 6.0,
                Accuracy = 9.0,
                TurretRotationSpeed = 28.0,
                FrontPlateArmorThickness = 950,
                SideArmorThickness = 700,
                HullArmorThickness = 850,
                RearArmorThickness = 400,
                TopSpeed = 64,
                FuelConsumption = 380,
                EnginePower = 1500,
                ImageUrl = "/Pic/Merkava.jpg",
                IsActive = true,
                WhenMade = 2004
            };

            Tanks K2BlackPanther = new Tanks
            {
                Id = 8,
                Brand = "Hyundai Rotem",
                Model = "K2 Black Panther",
                Country = "South Korea",
                Weight = 55.0,
                CrewSize = 3,
                Reliability = 9.0,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 4.0,
                Accuracy = 9.5,
                TurretRotationSpeed = 40.0,
                FrontPlateArmorThickness = 900,
                SideArmorThickness = 650,
                HullArmorThickness = 800,
                RearArmorThickness = 300,
                TopSpeed = 70,
                FuelConsumption = 330,
                EnginePower = 1500,
                ImageUrl = "/Pic/K2.jpg",
                IsActive = true,
                WhenMade = 2014
            };

            Tanks Ariete = new Tanks
            {
                Id = 9,
                Brand = "OTO Melara",
                Model = "C1 Ariete",
                Country = "Italy",
                Weight = 54.0,
                CrewSize = 4,
                Reliability = 7.5,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 6.5,
                Accuracy = 8.0,
                TurretRotationSpeed = 25.0,
                FrontPlateArmorThickness = 800,
                SideArmorThickness = 550,
                HullArmorThickness = 700,
                RearArmorThickness = 300,
                TopSpeed = 65,
                FuelConsumption = 350,
                EnginePower = 1270,
                ImageUrl = "/Pic/Ariete.jpg",
                IsActive = true,
                WhenMade = 1995
            };

            Tanks T14Armata = new Tanks
            {
                Id = 10,
                Brand = "Uralvagonzavod",
                Model = "T-14 Armata",
                Country = "Russia",
                Weight = 55.0,
                CrewSize = 3,
                Reliability = 8.0,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 125.0,
                ReloadSpeed = 5.0,
                Accuracy = 9.0,
                TurretRotationSpeed = 35.0,
                FrontPlateArmorThickness = 900,
                SideArmorThickness = 600,
                HullArmorThickness = 700,
                RearArmorThickness = 300,
                TopSpeed = 75,
                FuelConsumption = 380,
                EnginePower = 1500,
                ImageUrl = "/Pic/Armata.jpg",
                IsActive = true,
                WhenMade = 2015
            };
            Tanks T72B3 = new Tanks
            {
                Id = 11,
                Brand = "Uralvagonzavod",
                Model = "T-72B3",
                Country = "Russia",
                Weight = 46.5,
                CrewSize = 3,
                Reliability = 8.5,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 125.0,
                ReloadSpeed = 6.5,
                Accuracy = 7.5,
                TurretRotationSpeed = 24.0,
                FrontPlateArmorThickness = 750,
                SideArmorThickness = 500,
                HullArmorThickness = 650,
                RearArmorThickness = 250,
                TopSpeed = 70,
                FuelConsumption = 300,
                EnginePower = 1130,
                ImageUrl = "/Pic/T72B3.jpg",
                IsActive = true,
                WhenMade = 2013
            };

            Tanks T80U = new Tanks
            {
                Id = 12,
                Brand = "Omsktransmash",
                Model = "T-80U",
                Country = "Russia",
                Weight = 46.0,
                CrewSize = 3,
                Reliability = 7.5,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 125.0,
                ReloadSpeed = 6.0,
                Accuracy = 8.0,
                TurretRotationSpeed = 28.0,
                FrontPlateArmorThickness = 800,
                SideArmorThickness = 550,
                HullArmorThickness = 700,
                RearArmorThickness = 300,
                TopSpeed = 70,
                FuelConsumption = 450,
                EnginePower = 1250,
                ImageUrl = "/Pic/T80U.jpg",
                IsActive = true,
                WhenMade = 1985
            };

            Tanks M60A3 = new Tanks
            {
                Id = 13,
                Brand = "General Dynamics",
                Model = "M60A3",
                Country = "USA",
                Weight = 52.0,
                CrewSize = 4,
                Reliability = 8.0,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 105.0,
                ReloadSpeed = 8.5,
                Accuracy = 7.0,
                TurretRotationSpeed = 22.0,
                FrontPlateArmorThickness = 450,
                SideArmorThickness = 300,
                HullArmorThickness = 400,
                RearArmorThickness = 200,
                TopSpeed = 48,
                FuelConsumption = 350,
                EnginePower = 750,
                ImageUrl = "/Pic/M60A3.jpg",
                IsActive = true,
                WhenMade = 1978
            };

            Tanks Centurion = new Tanks
            {
                Id = 14,
                Brand = "Vickers",
                Model = "Centurion Mk 7",
                Country = "United Kingdom",
                Weight = 51.0,
                CrewSize = 4,
                Reliability = 7.5,
                Autoloader = false,
                ThermalVision = false,
                NightVision = true,
                MainGunCaliber = 105.0,
                ReloadSpeed = 9.0,
                Accuracy = 7.5,
                TurretRotationSpeed = 20.0,
                FrontPlateArmorThickness = 400,
                SideArmorThickness = 250,
                HullArmorThickness = 350,
                RearArmorThickness = 150,
                TopSpeed = 35,
                FuelConsumption = 320,
                EnginePower = 650,
                ImageUrl = "/Pic/Centurion.jpg",
                IsActive = true,
                WhenMade = 1953
            };

            Tanks Strv122 = new Tanks
            {
                Id = 15,
                Brand = "Bofors",
                Model = "Strv 122",
                Country = "Sweden",
                Weight = 62.5,
                CrewSize = 4,
                Reliability = 9.0,
                Autoloader = false,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 6.0,
                Accuracy = 9.5,
                TurretRotationSpeed = 30.0,
                FrontPlateArmorThickness = 950,
                SideArmorThickness = 650,
                HullArmorThickness = 800,
                RearArmorThickness = 350,
                TopSpeed = 68,
                FuelConsumption = 340,
                EnginePower = 1500,
                ImageUrl = "/Pic/Strv122.jpg",
                IsActive = true,
                WhenMade = 1997
            };

            Tanks Type10 = new Tanks
            {
                Id = 16,
                Brand = "Mitsubishi Heavy Industries",
                Model = "Type 10",
                Country = "Japan",
                Weight = 48.0,
                CrewSize = 3,
                Reliability = 9.0,
                Autoloader = true,
                ThermalVision = true,
                NightVision = true,
                MainGunCaliber = 120.0,
                ReloadSpeed = 4.0,
                Accuracy = 9.5,
                TurretRotationSpeed = 40.0,
                FrontPlateArmorThickness = 850,
                SideArmorThickness = 600,
                HullArmorThickness = 750,
                RearArmorThickness = 300,
                TopSpeed = 70,
                FuelConsumption = 300,
                EnginePower = 1200,
                ImageUrl = "/Pic/Type10.jpg",
                IsActive = true,
                WhenMade = 2012
            };

            tankList.Add(Leopard2A7V);
            tankList.Add(M1A2Abrams);
            tankList.Add(T90);
            tankList.Add(Challenger2);
            tankList.Add(Leclerc);
            tankList.Add(Type99);
            tankList.Add(MerkavaMk4);
            tankList.Add(K2BlackPanther);
            tankList.Add(Ariete);
            tankList.Add(T14Armata);
            tankList.Add(T72B3);
            tankList.Add(T80U);
            tankList.Add(M60A3);
            tankList.Add(Centurion);
            tankList.Add(Strv122);
            tankList.Add(Type10);

            return View(tankList);
        
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
