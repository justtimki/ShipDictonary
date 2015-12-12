using ShipDirectory.ShipModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShipDirectory.Repositories
{
    class TextRepository : AbstractRepository
    {
        
        public string FileName { get; set; }
        private string title = "Имя корабля;Тип:;Водоизмещение:;Страна-производитель:";
        protected override List<Ship> Ships { get; set; }
        protected override int Id { get; set; }

        private static TextRepository instance;

        private TextRepository()
        {
            Id = 0;
        }

        public static TextRepository getInstance()
        {
            if (instance == null)
                instance = new TextRepository();

            return instance;
        }

        public List<Ship> ReadFile()
        {
            if (FileName == null)
                throw new NullReferenceException("Для работы с этим репозиторием, Вам следует выбрать файл.");

            if (Ships == null)
                Ships = new List<Ship>();

            if (Ships != null)
            {
                Ships.Clear();
                Id = 0;
            }

            try
            {
                using (StreamReader sr = new StreamReader(FileName, Encoding.UTF8))
                {
                    sr.ReadLine();
                    string[] cell;
                    while (!sr.EndOfStream)
                    {
                        cell = sr.ReadLine().Split(';');
                        Ships.Add(new Ship(cell[0], cell[1], double.Parse(cell[2]), cell[3], Id));
                        Id++;
                    }
                }
            }
            catch(IOException e)
            {
                throw new IOException(e.Message);
            }
            return Ships;
        }

        public override void Update()
        {
            if (FileName == null)
                throw new NullReferenceException("Для работы с этим репозиторием, Вам следует выбрать файл.");

            using (StreamWriter sr = new StreamWriter(FileName, false, Encoding.UTF8))
            {
                sr.WriteLine(title);
                foreach (Ship item in Ships)
                {
                    sr.WriteLine(item.Name + ";" + item.Type + ";" + item.Displacement + ";" + item.Country);
                }
            }
        }
    }
}
