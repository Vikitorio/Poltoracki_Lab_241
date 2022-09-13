using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT
{
        class AdressHuman
        {
            private string _country;
            private string _city;
            private string _street;
            private int _house;
            
            public AdressHuman()
            {
                this._country = "Ukraine";
                this._city = "Kherson";
                this._street = "Poltawska";
                this._house = 44;
            }

            public AdressHuman(string country, string city, string street, int house)
            {
                this._country = country;
                this._city = city;
                this._street = street;
                this._house = house;
            }

            public string adressToString()
            {
                return
                    "Country: " + this._country + "\n" +
                    "City: " + this._city + "\n" +
                    "Street: " + this._street + "\n" +
                    "House: " + this._house.ToString();
            }
            public AdressHuman inputAdress(){
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Street: ");
            string street = Console.ReadLine();
            Console.WriteLine("House: ");
            int house = int.Parse(Console.ReadLine());
            AdressHuman adress = new AdressHuman(country, city, street, house);
            return adress;
        }
            public string Country
            {
                get { return _country; }
                set { _country = value; }
            }

            public string City
            {
                get { return _city; }
                set { _city = value; }
            }

            public string Street
            {
                get { return _street; }
                set { _street = value; }
            }

            public int House
            {
                get { return _house; }
                set { _house = value; }
            }
        }
    }
