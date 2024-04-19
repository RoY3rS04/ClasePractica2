using ClasePractica2;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayscaleImageConverter
{
    public class DirectoryRepository : IDirectoryRepository<string>
    {

        private string _sourceDir;
        private string _destinationDir;

        public DirectoryRepository(string sourceDir, string destinationDir)
        {
            _sourceDir = sourceDir;
            _destinationDir = destinationDir;

            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }
        }

        public void ApplyFilterToImage(string sourcePath, string destinationPath)
        {
            MessageBox.Show($"{sourcePath}, {destinationPath}");
            try
            {
                IFileRepository _repository = new FileRepository(sourcePath);

                FileStream? file = _repository.OpenOrCreateFile();

               if(file != null)
               {
                    using (MagickImage image = new MagickImage(file))
                    {
                        image.ColorSpace = ColorSpace.Gray;
                        image.Write(destinationPath);
                    }
               }

               _repository.CloseFile();
            } catch(IOException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Something went wrong when reading image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> GetAll()
        {
            return Directory
                .GetFiles(_sourceDir)
                .Where(file => file.EndsWith(".png") || file.EndsWith(".jpg"))
                .ToList();
        }

        public string GetDestinationDir()
        {
            return _destinationDir;
        }
    }
}
