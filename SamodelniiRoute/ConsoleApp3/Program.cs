using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Route
    {
        public List<City> cities;
        public int countCities;
        public Route(List<City> cities)
        {
            this.cities = cities;
            this.countCities = cities.Count();
        }
    }

    struct Point 
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct City
    {
        public Point points;
        public string Name;
        public City(Point point, string Name)
        {
            this.points = point;
            this.Name = Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadRoutes();
            ReadUserRoute();
            SearchUserRoute();
        }
        static List<Route> ReadRoutes()
        {
            List<Route> routes = new List<Route>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(Console.ReadLine()))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string count = line.Split(',')[0];
                    routes.Add(new Route(ReadCities(line)));
                }
            }
            return routes;
        }

        static List<City> ReadCities(string line)
        {
            List<City> cities = new List<City>();

            return cities;
        }

        static City ReadCity()
        {
            City city = new City();
            return city;
        }

        static Point ReadPoint()
        {
            Point point = new Point();
            return point;
        }
    }

}
