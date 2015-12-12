using ShipDirectory.ShipModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShipDirectory.Repositories
{
    abstract class AbstractRepository : IRepository
    {
        abstract protected List<Ship> Ships { get; set; }
        abstract protected int Id { get; set; }

        private const string SORT_OPTION_NAME = "name";
        private const string SORT_OPTION_DISPLACEMENT = "displacement";
        private const string SORT_OPTION_TYPE = "type";


        private const string FILTER_FIELD_NAME = "Имя";
        private const string FILTER_FIELD_TYPE = "Тип";
        private const string FILTER_FIELD_DISPLACEMENT = "Водоизмещение";
        private const string FILTER_FIELD_COUNTRY = "Страна-производитель";

        public abstract void Update();


        public List<Ship> GetAll()
        {
            return Ships;
        }

        public Ship GetById(int id)
        {
            if (id >= 0)
            {
                foreach (Ship item in Ships)
                {
                    if (item.Id == id)
                        return item;
                }
            }
            throw new Exception("Корабль #" + id + " не найден.");
        }

        public bool Add(Ship ship)
        {
            if (Ships == null)
                throw new NullReferenceException("Для работы с этим репозиторием, Вам следует выбрать файл.");

            ship.Id = Id;
            Id++;
            Ships.Add(ship);
            Update();

            return true;
        }

        public bool RemoveById(int id)
        {
            for (int i = 0; i < Ships.Count; i++)
            {
                if (Ships[i].Id == id)
                {
                    Ships.Remove(Ships[i]);
                    Update();
                    return true;
                }
            }
            return false;
                
        }

        public bool Sort(string sortOption)
        {
            if (Ships == null || sortOption == null)
                return false;

            if (sortOption.Equals(SORT_OPTION_NAME))
            {
                Ships.Sort(delegate(Ship s1, Ship s2)
                {
                    return s1.Name.CompareTo(s2.Name);
                });
                return true;
            } 
            else if (sortOption.Equals(SORT_OPTION_TYPE))
            {
                Ships.Sort(delegate(Ship s1, Ship s2)
                {
                    return s1.Type.CompareTo(s2.Type);
                });
                return true;
            }
            else if (sortOption.Equals(SORT_OPTION_DISPLACEMENT))
            {
                Ships.Sort(delegate(Ship s1, Ship s2)
                {
                   return s1.Displacement.CompareTo(s2.Displacement);
                });
                return true;
            }
            else
                return false;
        }


        public List<Ship> Filter(string field, string filterOption)
        {
            if (field.Equals(FILTER_FIELD_COUNTRY))
            {
                return Ships.Where(ship => (ship.Country.Equals(filterOption) || ship.Country.StartsWith(filterOption))).ToList();
            }
            else if (field.Equals(FILTER_FIELD_DISPLACEMENT))
            {
                return Ships.Where(ship => ship.Displacement.Equals(filterOption)).ToList();
            }
            else if (field.Equals(FILTER_FIELD_NAME))
            {
                return Ships.Where(ship => (ship.Name.Equals(filterOption) || ship.Name.StartsWith(filterOption))).ToList();
            }
            else if (field.Equals(FILTER_FIELD_TYPE))
            {
                return Ships.Where(ship => (ship.Type.Equals(filterOption) || ship.Type.StartsWith(filterOption))).ToList();
            }
            else throw new ArgumentException("Неверно задана опция!", "Фильтр");
        }
    }
}
