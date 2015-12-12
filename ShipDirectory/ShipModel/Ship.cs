using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDirectory.ShipModel
{
    [Serializable]
    public class Ship
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public double Displacement { get; private set; }
        public string Country { get; private set; }
        public int Id { get; set; }

        public Ship(string name, string type, double displacement, string country)
        {
            Name = name;
            Type = type;
            Displacement = displacement;
            Country = country;
        }

        public Ship(string name, string type, double displacement, string country, int id)
            : this(name, type, displacement, country)
        {
            Id = id;
        }

        public override string ToString()
        {
            return "№" + Id + " Корабль: " + Name +
                    "\r\n Тип: " + Type +
                    "\r\n Водоизмещение: " + Displacement +
                    "\r\n Страна-производитель: " + Country +
                    "\r\n_____________________________________";
        }
    }
}
