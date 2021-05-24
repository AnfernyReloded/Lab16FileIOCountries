using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Lab16_File_IO
{

    public class CountriesApp

    /*This displays a menu and responds to user choices*/
    {
        public static void CountriesAppMenu()
        {
            while (true)
            {

                //loop won't break
                //List won't print
                //you are dogwater at programming
                Console.WriteLine("Welcome to the Country List");
                Console.WriteLine("Press 1 see the list of countries");
                Console.WriteLine("Press 2 to add to the list of countries");
                Console.WriteLine("Press 3 to exit program");


                string menuchoice = Console.ReadLine();



                switch (menuchoice) //swtich statement works!!
                {
                    case "1":
                        Console.WriteLine($"Retrieving list of Countries");
                        
                        
                       
                        var countries = CountriesTextFile.ReadListFromFile("../../../CountryList.txt");

                        foreach (Country country  in countries)
                        {
                            Console.WriteLine($"Name:  {country.cName}| Capitol:  {country.cCapitol}| Population:  {country.cPopulation} million| Area:  {country.cArea} square kilometers");
                             
                        }
                        break;
                    
                    case "2":

                         Console.WriteLine("Enter information for new countries");

                         Console.WriteLine($"Enter the name of your country: ");
                         string usercountry = Console.ReadLine();

                         Console.WriteLine($"Now enter your countries capitol: ");
                         string usercapitol = Console.ReadLine();

                         Console.WriteLine($"Now enter the countries population: ");
                         string userpop = Console.ReadLine();
                         double numpop = double.Parse(userpop);

                         Console.WriteLine($"Finally, enter the square milage of you country: ");
                         string userarea = Console.ReadLine();
                         double numarea = double.Parse(userarea);

                         
                         List<Country> locallist = new List<Country>();

                         locallist.Add(new Country { cName = usercountry, cCapitol = usercapitol, cPopulation = numpop, cArea = numarea });

                         CountriesTextFile.WristListToFile(locallist);


                        break;
                    
                    case "3":
                        Console.WriteLine($"You chose menu option {menuchoice}, closing program");
                        break;
                        
                        
                        
                    //out "Exiting program, 
                    default:
                        Console.WriteLine("select valid choice");
                        continue;



                        

                }
                    if (menuchoice == "3")
                        {
                            Console.WriteLine($"Good bye!");
                            break;
                        }
              




            }

         
        }
    }
}



