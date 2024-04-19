using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayscaleImageConverter
{
    public class MediaProcessor
    {

        private IDirectoryRepository<string> _repository;

        public MediaProcessor(IDirectoryRepository<string> repo)
        {
            _repository = repo;
        }

        public void FilterPhotosInParallel()
        {
            List<string> imagePaths = _repository.GetAll();

            Parallel.ForEach(imagePaths, imagePath =>
            {
                string fileName = Path.GetFileName(imagePath);

                string destinationFile = Path.Combine(_repository.GetDestinationDir(), fileName);

                _repository.ApplyFilterToImage(imagePath, destinationFile);
            });
        }
    }
}
