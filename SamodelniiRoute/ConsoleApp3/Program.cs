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
        public Route(int countc, List<City> cities)
        {
            this.cities = cities;
            this.countCities = countc;
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
        public City(string Name, Point point)
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
        //cчитывание построчно маршрутов(списков городов на одной строчке)
        {
            int countc = 0;

            List<Route> routes = new List<Route>();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Console.ReadLine()))
            {
                string line;
                line = file.ReadLine();
                countc = Convert.ToInt32(line);
                while ((line = file.ReadLine()) != null)
                {
                    string[] informs = line.Split(new char[] { ' ' });//массив городов
                    routes.Add(new Route(countc,ReadCities(informs)));
                }
            }
            return routes;
        }

        static List<City> ReadCities(string[] informs)
        //считать города - informs[] это город
        {
            List<City> cities = new List<City>();

            for(int i = 0; i<=informs.Length;i++)
            {
                string[] informsCity = informs[i].Split(new char[] { '/' });//массив полей города
                cities.Add(ReadCity(informsCity));//добавление города в список городов
            }
            return cities;
        }
        
        static City ReadCity(string[] informsCity)
        //тут в теории массив из названия/х координаты/у координаты
        {
            City city = new City(informsCity[0],ReadPoint(informsCity[1], informsCity[1]));
            
            return city;
        }

        static Point ReadPoint(string x, string y)
        {
            Point point = new Point(Convert.ToInt32(x), (Convert.ToInt32(y)));
            return point;
        }
    }

}
