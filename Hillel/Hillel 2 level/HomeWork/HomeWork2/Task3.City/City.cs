using System;

namespace Task3.City
{
    partial class Program
    {
        class City
        {
            public string Title;
            GeoLocation Geo;
            public string Print()
            {
                return ($"I love {Title} located at {Geo.Latitude} N {Geo.Longitude} E");
            }

            public void SetInfo()
            {
                Console.WriteLine("Введите город : ");
                string city = Console.ReadLine();
                Title = city;
                Console.WriteLine("Введи координаты города: ");
                Console.WriteLine("Latitude(for example - 48° 27' 0.00'') : ");
                string latitude = Console.ReadLine();
                Console.WriteLine("Longitude(for example - 34° 58' 59.99''");
                string longitude = Console.ReadLine();
                Geo = new GeoLocation { Latitude = latitude, Longitude = longitude };
            }

        }
    }
}
