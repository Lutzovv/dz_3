using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Dishs : CafeAssortment
    {
        private double _calories;
        private double _weight;

        public Dishs(double calories, double weight, string dishName, double price, string category)
            : base(dishName, price, category, weight)
        {
            _calories = calories;
            _weight = weight;
        }

        public override string GetDishPrice() => base.GetDishPrice();

        public override string Information() => base.Information();
    }
}
