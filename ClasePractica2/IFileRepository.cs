using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica2
{
    public interface IFileRepository
    {
        Task<string> ReadFile();

        Task SaveFile(string data);

        FileStream? OpenOrCreateFile();

        void CloseFile();
    }
}
