using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Animals
    {
        private string _name;
        private string _breed;
        private string _birthDate;
        private double _weight;

        public Animals(string name, string breed, string birthDate, double weight)
        {
            _name = name;
            _breed = breed;
            _birthDate = birthDate;
            _weight = weight;
        }

        public virtual string Information() => $"Имя: {_name}\nПорода: {_breed}\nВес: {_weight}\nДата рождения: {_birthDate}";
    }
}
