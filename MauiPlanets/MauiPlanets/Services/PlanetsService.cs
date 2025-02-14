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
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years. Its largest crater, Caloris Planitia, has a diameter of 1,550 km (960 mi), which is about one-third the diameter of the planet (4,880 km or 3,030 mi). Similarly to the Earth's Moon, Mercury's surface displays an expansive rupes system generated from thrust faults and bright ray systems formed by impact event remnants.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8D9098"),
                Images = new List<string>
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new Planet()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level. These extreme conditions compress carbon dioxide into a supercritical state at Venus's surface.",
                AccentColorStart = Color.FromArgb("#A6393B"),
                AccentColorEnd = Color.FromArgb("#D17F21"),
                Images = new List<string>
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new Planet()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere. Most of Earth's land is at least somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers, and atmospheric water combined. Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation.",
                AccentColorStart = Color.FromArgb("#0E3D68"),
                AccentColorEnd = Color.FromArgb("#2E97C7"),
                Images = new List<string>
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new Planet()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun. The surface of Mars is orange-red because it is covered in iron(III) oxide dust, giving it the nickname \"the Red Planet\".[22][23] Mars is among the brightest objects in Earth's sky, and its high-contrast albedo features have made it a common subject for telescope viewing. It is classified as a terrestrial planet and is the second smallest of the Solar System's planets with a diameter of 6,779 km (4,212 mi). In terms of orbital motion, a Martian solar day (sol) is equal to 24.6 hours, and a Martian solar year is equal to 1.88 Earth years (687 Earth days). Mars has two natural satellites that are small and irregular in shape: Phobos and Deimos.",
                AccentColorStart = Color.FromArgb("#A23036"),
                AccentColorEnd = Color.FromArgb("#EB3333"),
                Images = new List<string>
                {
                   "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                   "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                   "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new Planet()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar System combined and slightly less than one-thousandth the mass of the Sun. Its diameter is eleven times that of Earth, and a tenth that of the Sun. Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm), with an orbital period of 11.86 years. It is the third-brightest natural object in the Earth's night sky, after the Moon and Venus, and has been observed since prehistoric times. Its name derives from that of Jupiter, the chief deity of ancient Roman religion.",
                AccentColorStart = Color.FromArgb("#9D4A40"),
                AccentColorEnd = Color.FromArgb("#CD8026"),
                Images = new List<string>
                {
                   "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new Planet()
            {
                Name = "Saturn",
                Subtitle = "The ring giant",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth.[27][28] It has an eighth the average density of Earth, but is over 95 times more massive.[29][30][31] Even though Saturn is almost as big as Jupiter, Saturn has less than a third its mass. Saturn orbits the Sun at a distance of 9.59 AU (1,434 million km), with an orbital period of 29.45 years.\r\n\r\nSaturn's interior is thought to be composed of a rocky core, surrounded by a deep layer of metallic hydrogen, an intermediate layer of liquid hydrogen and liquid helium, and an outer layer of gas. Saturn has a pale yellow hue, due to ammonia crystals in its upper atmosphere. An electrical current in the metallic hydrogen layer is thought to give rise to Saturn's planetary magnetic field, which is weaker than Earth's, but has a magnetic moment 580 times that of Earth because of Saturn's greater size. Saturn's magnetic field strength is about a twentieth that of Jupiter.[32] The outer atmosphere is generally bland and lacking in contrast, although long-lived features can appear. Wind speeds on Saturn can reach 1,800 kilometres per hour (1,100 miles per hour).",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#C6502F"),
                Images = new List<string>
                {
                   "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new Planet()
            {
                Name = "Uranus",
                Subtitle = "The Herschel giant",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets. It has a marked axial tilt of 82.23° with a retrograde rotation period of 17 hours and 14 minutes. This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.\r\n\r\nUranus has the third-largest diameter and fourth-largest mass among the Solar System's planets. Based on current models, inside its volatile mantle layer is a rocky core, and surrounding it is a thick hydrogen and helium atmosphere. Trace amounts of hydrocarbons (thought to be produced via hydrolysis) and carbon monoxide along with carbon dioxide (thought to have been originated from comets) have been detected in the upper atmosphere. There are many unexplained climate phenomena in Uranus's atmosphere, such as its peak wind speed of 900 km/h (560 mph),[23] variations in its polar cap, and its erratic cloud formation. The planet also has very low internal heat compared to other giant planets, the cause of which remains unclear.",
                AccentColorStart = Color.FromArgb("#9D4A40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new List<string>
                {
                   "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                   "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new Planet()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth. Compared to its fellow ice giant Uranus, Neptune is slightly more massive, but denser and smaller. Being composed primarily of gases and liquids,[21] it has no well-defined solid surface, and orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical symbol ♆, representing Neptune's trident.[e]\r\n\r\nNeptune is not visible to the unaided eye and is the only planet in the Solar System that was not initially observed by direct empirical observation. Rather, unexpected changes in the orbit of Uranus led Alexis Bouvard to hypothesise that its orbit was subject to gravitational perturbation by an unknown planet. After Bouvard's death, the position of Neptune was mathematically predicted from his observations, independently, by John Couch Adams and Urbain Le Verrier. Neptune was subsequently directly observed with a telescope on 23 September 1846[2] by Johann Gottfried Galle within a degree of the position predicted by Le Verrier. Its largest moon, Triton, was discovered shortly thereafter, though none of the planet's remaining moons were located telescopically until the 20th century.",
                AccentColorStart = Color.FromArgb("#0C293D"),
                AccentColorEnd = Color.FromArgb("#26ABE0"),
                Images = new List<string>
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
        };
        public static List<Planet> GetFeaturedPlanets()
        {
            var rng = new Random();
            var randomizePlanets = planets.OrderBy(p => rng.Next());
            return randomizePlanets.Take(2).ToList();
        }
        public static List<Planet> GetAllPlanets()
        {
            return planets;
        }

    }
}
