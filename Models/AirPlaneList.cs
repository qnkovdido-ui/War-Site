namespace Nazi.Models
{
    public class AirPlaneList
    {

        public List<AirPlaneList> GetAirPlanes()
        {
            var airPlanes = new List<AirPlaneList>();

            AirPlaneList EuroFighterTyphoon = new AirPlaneList()
            {
                id = 1,
                brand = "Eurofighter Jagdflugzeug GmbH",
                model = "EF2000",
                Maxspeed = 2495,
                FirstFlightSate = new DateTime(1994, 3, 4),
                IsActive = true,
                ImageUrl = "/Pic/EurofighterTyphoon.jpg"
            };

            AirPlaneList F22 = new AirPlaneList()
            {
                id = 2,
                brand = "Lockheed Martin",
                model = "F-22 Raptor",
                Maxspeed = 2410,
                FirstFlightSate = new DateTime(1997, 9, 7),
                IsActive = true,
                ImageUrl = "/Pic/F22.jpg"
            };

            AirPlaneList Su57 = new AirPlaneList()
            {
                id = 3,
                brand = "Sukhoi",
                model = "Su-57",
                Maxspeed = 2600,
                FirstFlightSate = new DateTime(2010, 1, 29),
                IsActive = true,
                ImageUrl = "/Pic/Su57.jpg"
            };

            AirPlaneList F35 = new AirPlaneList()
            {
                id = 4,
                brand = "Lockheed Martin",
                model = "F-35 Lightning II",
                Maxspeed = 1930,
                FirstFlightSate = new DateTime(2006, 12, 15),
                IsActive = true,
                ImageUrl = "/Pic/F35.jpg"
            };

            AirPlaneList Rafale = new AirPlaneList()
            {
                id = 5,
                brand = "Dassault Aviation",
                model = "Rafale",
                Maxspeed = 1912,
                FirstFlightSate = new DateTime(1986, 7, 4),
                IsActive = true,
                ImageUrl = "/Pic/Rafale.jpg"
            };

            AirPlaneList Mig29 = new AirPlaneList()
            {
                id = 6,
                brand = "Mikoyan",
                model = "MiG-29",
                Maxspeed = 2450,
                FirstFlightSate = new DateTime(1977, 10, 6),
                IsActive = true,
                ImageUrl = "/Pic/Mig29.jpg"
            };

            AirPlaneList Mig31 = new AirPlaneList()
            {
                id = 7,
                brand = "Mikoyan",
                model = "MiG-31",
                Maxspeed = 3000,
                FirstFlightSate = new DateTime(1975, 9, 16),
                IsActive = true,
                ImageUrl = "/Pic/Mig31.jpg"
            };

            AirPlaneList F16 = new AirPlaneList()
            {
                id = 8,
                brand = "General Dynamics",
                model = "F-16 Fighting Falcon",
                Maxspeed = 2120,
                FirstFlightSate = new DateTime(1974, 2, 2),
                IsActive = true,
                ImageUrl = "/Pic/F16.jpg"
            };
            AirPlaneList J20 = new AirPlaneList()
            {
                id = 9,
                brand = "Chengdu Aerospace Corporation",
                model = "J-20 Mighty Dragon",
                Maxspeed = 2100,
                FirstFlightSate = new DateTime(2011, 1, 11),
                IsActive = true,
                ImageUrl = "/Pic/J20.jpg"
            };
            AirPlaneList Gripen = new AirPlaneList()
            {
                id = 10,
                brand = "Saab AB",
                model = "JAS 39 Gripen",
                Maxspeed = 2200,
                FirstFlightSate = new DateTime(1988, 12, 9),
                IsActive = true,
                ImageUrl = "/Pic/Gripen.jpg"
            };
            AirPlaneList F15 = new AirPlaneList()
            {
                id = 11,
                brand = "McDonnell Douglas",
                model = "F-15 Eagle",
                Maxspeed = 2655,
                FirstFlightSate = new DateTime(1972, 7, 27),
                IsActive = true,
                ImageUrl = "/Pic/F15.jpg"
            };

            AirPlaneList F18 = new AirPlaneList()
            {
                id = 12,
                brand = "McDonnell Douglas / Boeing",
                model = "F/A-18 Hornet",
                Maxspeed = 1915,
                FirstFlightSate = new DateTime(1978, 11, 18),
                IsActive = true,
                ImageUrl = "/Pic/F18.jpg"
            };

            AirPlaneList SuperHornet = new AirPlaneList()
            {
                id = 13,
                brand = "Boeing",
                model = "F/A-18E/F Super Hornet",
                Maxspeed = 1915,
                FirstFlightSate = new DateTime(1995, 11, 29),
                IsActive = true,
                ImageUrl = "/Pic/SuperHornet.jpg"
            };

            AirPlaneList F14 = new AirPlaneList()
            {
                id = 14,
                brand = "Grumman",
                model = "F-14 Tomcat",
                Maxspeed = 2485,
                FirstFlightSate = new DateTime(1970, 12, 21),
                IsActive = false,
                ImageUrl = "/Pic/F14.jpg"
            };

            AirPlaneList Mirage2000 = new AirPlaneList()
            {
                id = 15,
                brand = "Dassault Aviation",
                model = "Mirage 2000",
                Maxspeed = 2336,
                FirstFlightSate = new DateTime(1978, 3, 10),
                IsActive = true,
                ImageUrl = "/Pic/Mirage2000.jpg"
            };

            AirPlaneList MirageF1 = new AirPlaneList()
            {
                id = 16,
                brand = "Dassault Aviation",
                model = "Mirage F1",
                Maxspeed = 2340,
                FirstFlightSate = new DateTime(1966, 12, 23),
                IsActive = false,
                ImageUrl = "/Pic/MirageF1.jpg"
            };

            AirPlaneList Su27 = new AirPlaneList()
            {
                id = 17,
                brand = "Sukhoi",
                model = "Su-27",
                Maxspeed = 2500,
                FirstFlightSate = new DateTime(1977, 5, 20),
                IsActive = true,
                ImageUrl = "/Pic/Su27.jpg"
            };

            AirPlaneList Su30 = new AirPlaneList()
            {
                id = 18,
                brand = "Sukhoi",
                model = "Su-30",
                Maxspeed = 2120,
                FirstFlightSate = new DateTime(1989, 12, 31),
                IsActive = true,
                ImageUrl = "/Pic/Su30.jpg"
            };

            AirPlaneList Su35 = new AirPlaneList()
            {
                id = 19,
                brand = "Sukhoi",
                model = "Su-35",
                Maxspeed = 2400,
                FirstFlightSate = new DateTime(2008, 2, 19),
                IsActive = true,
                ImageUrl = "/Pic/Su35.jpg"
            };

            AirPlaneList Su34 = new AirPlaneList()
            {
                id = 20,
                brand = "Sukhoi",
                model = "Su-34",
                Maxspeed = 1900,
                FirstFlightSate = new DateTime(1990, 4, 13),
                IsActive = true,
                ImageUrl = "/Pic/Su34.jpg"
            };

            AirPlaneList Mig25 = new AirPlaneList()
            {
                id = 21,
                brand = "Mikoyan",
                model = "MiG-25",
                Maxspeed = 3000,
                FirstFlightSate = new DateTime(1964, 3, 6),
                IsActive = false,
                ImageUrl = "/Pic/Mig25.jpg"
            };

            AirPlaneList Mig35 = new AirPlaneList()
            {
                id = 22,
                brand = "Mikoyan",
                model = "MiG-35",
                Maxspeed = 2400,
                FirstFlightSate = new DateTime(2007, 2, 6),
                IsActive = true,
                ImageUrl = "/Pic/Mig35.jpg"
            };

            AirPlaneList J10 = new AirPlaneList()
            {
                id = 23,
                brand = "Chengdu Aerospace Corporation",
                model = "J-10",
                Maxspeed = 2200,
                FirstFlightSate = new DateTime(1998, 3, 23),
                IsActive = true,
                ImageUrl = "/Pic/J10.jpg"
            };

            AirPlaneList JF17 = new AirPlaneList()
            {
                id = 24,
                brand = "Chengdu / Pakistan Aeronautical Complex",
                model = "JF-17 Thunder",
                Maxspeed = 1910,
                FirstFlightSate = new DateTime(2003, 8, 25),
                IsActive = true,
                ImageUrl = "/Pic/JF17.jpg"
            };

            AirPlaneList Tejas = new AirPlaneList()
            {
                id = 25,
                brand = "HAL",
                model = "HAL Tejas",
                Maxspeed = 2205,
                FirstFlightSate = new DateTime(2001, 1, 4),
                IsActive = true,
                ImageUrl = "/Pic/Tejas.jpg"
            };



            return airPlanes;
        }

    }
}
