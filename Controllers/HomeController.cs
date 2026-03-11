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
            AirPlane[] airPlanes = { EuroFighterTyphoon, F22, Su57, F35, Rafale, Mig29, Mig31, F16, J20, Gripen };
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
