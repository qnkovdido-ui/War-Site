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
            AirPlane Su37 = new AirPlane()
            {
                id = 11,
                brand = "Sukhoi",
                model = "Su-37 “Terminator”",
                Maxspeed = 2500,
                FirstFlightSate = new DateTime(1996, 4, 12),
                IsActive = true,
                ImageUrl = "/Pic/Su37.jpg"
            };
            AirPlane B2 = new AirPlane()
            {
                id = 12,
                brand = "Northrop Corporation",
                model = "Northrop B-2 Spirit",
                Maxspeed = 1010,
                FirstFlightSate = new DateTime(1989, 7, 17),
                IsActive = true,
                ImageUrl = "/Pic/B2.jpg"
            };
            AirPlane B1 = new AirPlane()
            {
                id = 13,
                brand = "Rockwell International",
                model = "Rockwell B?1 Lancer",
                Maxspeed = 1335,
                FirstFlightSate = new DateTime(1974, 12, 23),
                IsActive = true,
                ImageUrl = "/Pic/B1.jpg"
            };
            AirPlane F18 = new AirPlane()
            {
                id = 14,
                brand = "McDonnell Douglas",
                model = "F/A-18 Hornet",
                Maxspeed = 1915,
                FirstFlightSate = new DateTime(1978, 11, 18),
                ImageUrl = "/Pic/F18.jpg"
            };
            AirPlane Su35 = new AirPlane()
            {
                id = 15,
                brand = "Sukhoi",
                model = "Sukhoi Su-35",
                Maxspeed = 2390,
                FirstFlightSate = new DateTime(2008, 2, 19),
                ImageUrl = "/Pic/Su35.jpg"
            };
            AirPlane F15 = new AirPlane()
            {
                id = 16,
                brand = "Boeing",
                model = "F-15 Eagle",
                Maxspeed = 2655,
                FirstFlightSate = new DateTime(1972, 7, 27),
                ImageUrl = "/Pic/F15.jpg"
            };













            AirPlane[] airPlanes = { EuroFighterTyphoon, F22, Su57, F35, Rafale, Mig29, Mig31, F16, J20, Gripen, Su37, B2, B1, F18, Su35, F15 };
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
            airplaneList.Add(Su37);
            airplaneList.Add(B2);
            airplaneList.Add(B1);
            airplaneList.Add(F18);
            airplaneList.Add(Su35);
            airplaneList.Add(F15);

            return View(airplaneList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
