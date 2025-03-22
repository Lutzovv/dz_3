using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz3
{
    public class Cat2 : Animals
    {
        public Cat2(string name, string breed, string birthDate, double weight) : base(name, breed, birthDate, weight) { }

        public bool CatchMouse(int num)
        {
            if (num <= 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string Information() => base.Information();
    }
}
