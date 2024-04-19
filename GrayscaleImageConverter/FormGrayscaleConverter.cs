using ClasePractica2;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayscaleImageConverter
{
    public partial class FormGrayscaleConverter : Form
    {

        private IDirectoryRepository<string> _repository;
        private MediaProcessor _mediaProcessor;
        private string _sourceDir;

        public FormGrayscaleConverter()
        {
            InitializeComponent();
        }

        private void FromDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string dirPath;

            using (var dirChooser = new FolderBrowserDialog())
            {
                result = dirChooser.ShowDialog();

                dirPath = dirChooser.SelectedPath;
            }

            if (result != DialogResult.OK)
            {
                return;
            }

            if (string.IsNullOrEmpty(dirPath))
            {
                MessageBox.Show("Invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _sourceDir = dirPath;
        }

        private void ToDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string dirPath;

            using (var dirChooser = new FolderBrowserDialog())
            {
                result = dirChooser.ShowDialog();

                dirPath = dirChooser.SelectedPath;
            }

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(dirPath))
            {
                MessageBox.Show("Invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_sourceDir == null)
            {
                MessageBox.Show("Please select your source directory first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _repository = new DirectoryRepository(_sourceDir, dirPath);
            _mediaProcessor = new MediaProcessor(_repository);
            ApplyFilterBtn.Enabled = true;
        }

        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            _mediaProcessor.FilterPhotosInParallel();

            MessageBox.Show("Filters applied successfully!");
        }
    }
}
