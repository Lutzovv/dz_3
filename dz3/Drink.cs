using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Drinks : CafeAssortment
    {
        private double _volume;

        public Drinks(double volume, string dishName, double price, string category, double weight)
           : base(dishName, price, category, weight)
        {
            _volume = volume;
        }

        public override string Information() => base.Information();

        public override string CostOfDrink(int percent) => base.CostOfDrink(15);

    }
}
