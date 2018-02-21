using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smogger_beta.Models
{
    public class Location
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

    public class CityChooser
    {
        public static List<Location> GetCities()
        {
            var cities = new List<Location>();

            cities.Add(new Location { CityId = 01, CityName = "Kraków" });
            cities.Add(new Location { CityId = 02, CityName = "Tarnów" });
            cities.Add(new Location { CityId = 03, CityName = "Nowy Sącz" });
            //cities.Add(new Location { CityId = 04, CityName = "Bochnia" });
            //cities.Add(new Location { CityId = 05, CityName = "Brzesko" });
            //cities.Add(new Location { CityId = 06, CityName = "Chrzanów" });
            //cities.Add(new Location { CityId = 07, CityName = "Dąbrowa Tarnowska" });
            //cities.Add(new Location { CityId = 08, CityName = "Gorlice" });
            //cities.Add(new Location { CityId = 09, CityName = "Krynica Zdrój" });
            //cities.Add(new Location { CityId = 10, CityName = "Limanowa" });
            //cities.Add(new Location { CityId = 11, CityName = "Miechów" });
            //cities.Add(new Location { CityId = 12, CityName = "Myślenice" });
            cities.Add(new Location { CityId = 13, CityName = "Nowy Targ" });
            cities.Add(new Location { CityId = 14, CityName = "Olkusz" });
            //cities.Add(new Location { CityId = 15, CityName = "Oświęcim" });
            //cities.Add(new Location { CityId = 16, CityName = "Proszowice" });
            cities.Add(new Location { CityId = 17, CityName = "Skawina" });
            //cities.Add(new Location { CityId = 18, CityName = "Sucha Beskidzka" });
            cities.Add(new Location { CityId = 19, CityName = "Trzebinia" });
            //cities.Add(new Location { CityId = 20, CityName = "Tuchów" });
            //cities.Add(new Location { CityId = 21, CityName = "Wadowice" });
            //cities.Add(new Location { CityId = 22, CityName = "Wieliczka" });
            cities.Add(new Location { CityId = 23, CityName = "Zakopane" });

            return cities;
        }

    }
}
