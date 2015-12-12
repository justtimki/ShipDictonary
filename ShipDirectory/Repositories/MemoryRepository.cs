using ShipDirectory.ShipModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDirectory.Repositories
{
    class MemoryRepository : AbstractRepository
    {
        private static readonly MemoryRepository instance = new MemoryRepository();
        protected override int Id { get; set; }
        protected override List<Ship> Ships { get; set; }

        private MemoryRepository()
        {
            Ships = new List<Ship>();
        }

        public static MemoryRepository Instance
        {
            get { return instance; }
        }

        public override void Update()
        {
        }
    }
}
