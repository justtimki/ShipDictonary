using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipDirectory.ShipModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ShipDirectory.Repositories
{
    class BinaryRepository : AbstractRepository
    {  
        private static BinaryRepository instance;
        public string FileName { get; set; }
        protected override List<Ship> Ships { get; set; }
        protected override int Id { get; set; }

        private BinaryRepository()
        {
            Id = 0;
        }

        public static BinaryRepository getInstance()
        {
            if (instance == null)
                instance = new BinaryRepository();
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
                using (Stream reader = new FileStream(FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        Ships = (List<Ship>)bf.Deserialize(reader);
                        updateId();
                    }
                    catch (SerializationException)
                    {
                        Ships = new List<Ship>();
                    }
                }
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
            return Ships;
        }

        public override void Update()
        {
            if (FileName == null)
                throw new NullReferenceException("Для работы с этим репозиторием, Вам следует выбрать файл.");

            using (Stream writer = File.Open(FileName, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(writer, Ships);
            }
        }

        private void updateId()
        {
            int i = 0;
            foreach (var item in Ships)
            {
                item.Id = i++;
            }
            Id = i;
        }
    }
}
