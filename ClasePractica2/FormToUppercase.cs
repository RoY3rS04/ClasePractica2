using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePractica2
{
    public partial class FormToUppercase : Form
    {
        private FileRepository _repository;

        public FormToUppercase()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new OpenFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();

                fileName = fileChooser.FileName;
            }

            if (result != DialogResult.OK)
            {
                return;
            }

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _repository = new FileRepository(fileName);

            try
            {
                _repository.OpenOrCreateFile();
                btnSaveFile.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSaveFile_Click(object sender, EventArgs e)
        {

            if(destinationTxtBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill the destination textbox", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                IFileRepository destinationRepo = new FileRepository(destinationTxtBox.Text);

                destinationRepo.OpenOrCreateFile();

                string originData = await _repository.ReadFile();

                await destinationRepo.SaveFile(
                    originData.ToUpper()    
                );

                destinationRepo.CloseFile();
                _repository.CloseFile();

                MessageBox.Show("File saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
