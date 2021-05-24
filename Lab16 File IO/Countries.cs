using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16_File_IO
{
    public class Country
    {
        public string cName { get; set; }
        public string cCapitol { get; set; }
        public double cPopulation { get; set; }

        public double cArea { get; set; }

        public Country()
        {

        }

        public Country(string name, string capitol, double population, double area)
        {
            cName = name;
            cCapitol = capitol;
            cPopulation = population;
            cArea = area;
        }

        public static List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>
            {
                new Country("Amestris", "Central City",30000000, 726456),
                new Country("Wakanda", "Binin T'Chaka", 6000000,  78112),
                new Country("Latvaria", "Doomstadt", 500000, 5856),
                new Country("Zion","Temple",260000 ,5000 ),
                new Country("Asgard", "The Castle", 50000, 10000 ),
            };

            return countries;
        }

    }
}


