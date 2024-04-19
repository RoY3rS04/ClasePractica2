using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayscaleImageConverter
{
    public interface IDirectoryRepository<T>
    {
        List<T> GetAll();

        void ApplyFilterToImage(T sourcePath, T destinationPath);

        string GetDestinationDir();
    }
}
