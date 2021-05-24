using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab16_File_IO
{
     /*this class will contain a single method that allows you to read a list of countries from a file, 
     * and another method that allows you to write a list of countries to a file
     */
    public class CountriesTextFile
    {
        public static List<Country> ReadListFromFile(string path)
        {
            //"../../../CountryList.txt"

            List<Country> countries1 = new List<Country>();
            StreamReader reader = new StreamReader("../../../CountryList.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] countryProperties = line.Split('|');
                countries1.Add(new Country(countryProperties[0], countryProperties[1], double.Parse(countryProperties[2]), double.Parse(countryProperties[3])));
                line = reader.ReadLine();
            }
            reader.Close();
            return countries1;

            //this method is going be able to read a list of countries from a file.

        }

        public static void WristListToFile(List<Country> countries)
        {
            // List<Country> countries1 = Country.GetCountries();

            StreamWriter writer = new StreamWriter("../../../CountryList.txt", true);
            foreach (Country country in countries)
            {
                //writing each character object to the file on at a time
                writer.WriteLine($"{country.cName}|{country.cCapitol}|{country.cPopulation}|{country.cArea}");
            }
            writer.Close();



            //this method is going to able to write a list to a file.
        }

        public static void AddToList(List<Country> countries)
        {
            List<Country> countries1 = Country.GetCountries();
            List<Country> countries2 = new List<Country>();
            StreamWriter writer = new StreamWriter("../../../CountryList.txt");
            countries1.AddRange(countries2);
            writer.Close();
        }

        //
    }
}


