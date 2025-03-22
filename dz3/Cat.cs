using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Cat
    {
        private string _name;
        private string _breed;
        private double _weight;
        private double _height;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public double Height
        {
            get => _height;
            set => _height = value;
        }
        public double Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public string Breed { get; }

        public string CatOwner { get; }

        public Cat(string name, string breed, double weight, double height)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
            Height = height;
        }

        public string Information() => $"Кличка: {Name}, Рост: {Height}, Вес: {Weight}, Порода: {Breed}, Владелец: {CatOwner}";
    }
}
