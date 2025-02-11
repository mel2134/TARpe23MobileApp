using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new List<Planet>
        {
            new Planet()
            {
                Name = "Mercury",
                Subtitle = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years. Its largest crater, Caloris Planitia, has a diameter of 1,550 km (960 mi), which is about one-third the diameter of the planet (4,880 km or 3,030 mi). Similarly to the Earth's Moon, Mercury's surface displays an expansive rupes system generated from thrust faults and bright ray systems formed by impact event remnants.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8D9098"),
                Images = new List<string>
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }

            }
        };
        public static List<Planet> GetFeaturedPlanets()
        {
            var rng = new Random().Next();
            var randomizePlanets = planets.OrderBy(p => rng);
            return randomizePlanets.Take(2).ToList();
        }
        public static List<Planet> GetAllPlanets()
        {
            return planets;
        }

    }
}
