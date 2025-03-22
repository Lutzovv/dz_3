using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Tower : Attractions
    {
        public Tower(string name, double duration, int maxSeats, double price) : base(name, duration, maxSeats, price) { }

        public override double GetRevenue(int people = 0) => base.GetRevenue(people);

        public override string Information() => base.Information();
    }
}
