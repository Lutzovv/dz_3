using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz3
{
    public class CatMethod
    {
        private string name;
        private string breed;
        private double weight;
        private double height;
        private string catOwner;

        public CatMethod(string name, string breed, double weight, double height, string catOwner)
        {
            this.name = name;
            this.breed = breed;
            this.weight = weight;
            this.height = height;
            this.catOwner = catOwner;
        }

        public void SetName(string name) => this.name = name;
        public string GetName() => this.name;

        public void SetWeight(double weight) => this.weight = weight;
        public double GetWeight() => this.weight;

        public void SetHeight(double height) => this.height = height;
        public double GetHeight() => height;

        public void SetCatOwner(string catOwner) => this.catOwner = catOwner;
        public string GetCatOwner() => catOwner;

        public string Information() => $"Кличка: {name}, Рост: {height}, Вес: {weight}, Порода: {breed}, Владелец: {catOwner}";
    }
}
