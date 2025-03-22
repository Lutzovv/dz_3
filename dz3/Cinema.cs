using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Cinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;

        public string MovieName
        {
            get => _movieName;
            set => _movieName = value;
        }

        public double Price => _price;

        public string CinemaHall { get; }

        public Cinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            CinemaHall = cinemaHall;
        }

        public string Information() => $"Название фильма: {MovieName}\nЦена билета: {Price}\nВместимось: {_peopleCapacity}\nКинозал: {CinemaHall}";
    }
}
