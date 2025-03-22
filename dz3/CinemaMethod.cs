using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class CinemaMethod
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;
        private string _cinemaHall;

        public void SetMovieName(string movieName) => _movieName = movieName;
        public string GetMovieName() => _movieName;

        public double GetPrice() => _price;

        public string GetCinemaHall() => _cinemaHall;

        public CinemaMethod(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            _cinemaHall = cinemaHall;
        }

        public string Information() => $"Название фильма: {_movieName}\nЦена билета: {_price}\nВместимось: {_peopleCapacity}\nКинозал: {_cinemaHall}";
    }
}