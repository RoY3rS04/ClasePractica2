using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica2
{
    public class FileRepository : IFileRepository
    {

        private string _filePath;
        private FileStream? _stream;
        private StreamReader? _streamReader;
        private StreamWriter? _streamWriter;

        public FileRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void CloseFile()
        {
            try
            {
                _streamWriter?.Close();
                _streamReader?.Close();
            } catch (IOException ex)
            {
                throw new IOException("Something went wrong when closing the file");
            }
        }

        public FileStream? OpenOrCreateFile()
        {
            try
            {
                _stream = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                _streamWriter = new StreamWriter(_stream);
                _streamReader = new StreamReader(_stream);

                return _stream;
            }catch(IOException ex) {
                throw new IOException($"Something went wrong when opening the file, {ex.Message}");
            }
        }

        public async Task<string> ReadFile()
        {
            try
            {
                return await _streamReader?.ReadToEndAsync() ?? "";
            } catch(IOException ex)
            {
                throw new IOException("Something went wrong when reading the file");
            }
        }

        public async Task SaveFile(string data)
        {
            try
            {
                await _streamWriter?.WriteLineAsync(data);
            } catch (IOException ex)
            {
                throw new IOException("Something went wrong when saving the file");
            }
        }
    }
}
