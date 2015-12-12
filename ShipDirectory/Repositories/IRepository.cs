using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ShipDirectory.ShipModel;

namespace ShipDirectory.Repositories
{
    public interface IRepository
    {
        List<Ship> GetAll();
        Ship GetById(int id);
        bool Add(Ship ship);
        void Update();
        bool RemoveById(int id);
        bool Sort(string sortOption);
        List<Ship> Filter(string field, string filterOption);
    }
}
