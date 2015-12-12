using ShipDirectory.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDirectory.Factory
{
    public abstract class AbstractFactory
    {
        public static IRepository createMemoryRepository()
        {
            return MemoryRepository.Instance;
        }

        public static IRepository createTextRepository(string fileName)
        {
            if (fileName != null)
            {
                try
                {
                    TextRepository.getInstance().FileName = fileName;
                    TextRepository.getInstance().ReadFile();
                } 
                catch(IOException e)
                {
                    throw new IOException(e.Message);
                }
            }
            return TextRepository.getInstance();
        }

        public static IRepository createBinaryRepository(string fileName)
        {
            if(fileName != null)
            {
                try
                {
                    BinaryRepository.getInstance().FileName = fileName;
                    BinaryRepository.getInstance().ReadFile();
                }
                catch (IOException e)
                {
                    throw new IOException(e.Message);
                }
            }
            return BinaryRepository.getInstance();
        }
    }
}
