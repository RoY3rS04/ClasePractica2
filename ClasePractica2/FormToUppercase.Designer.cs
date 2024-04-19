namespace ClasePractica2
{
    partial class FormToUppercase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLbl = new Label();
            btnSelectFile = new Button();
            btnSaveFile = new Button();
            destinationLbl = new Label();
            destinationTxtBox = new TextBox();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(56, 40);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(219, 20);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Convert txt files to UpperCase";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(56, 143);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(219, 46);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Select your file";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(56, 218);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(219, 41);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // destinationLbl
            // 
            destinationLbl.AutoSize = true;
            destinationLbl.Location = new Point(56, 93);
            destinationLbl.Name = "destinationLbl";
            destinationLbl.Size = new Size(92, 15);
            destinationLbl.TabIndex = 3;
            destinationLbl.Text = "Destination file :";
            // 
            // destinationTxtBox
            // 
            destinationTxtBox.Location = new Point(175, 90);
            destinationTxtBox.Name = "destinationTxtBox";
            destinationTxtBox.Size = new Size(100, 23);
            destinationTxtBox.TabIndex = 4;
            // 
            // FormToUppercase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 321);
            Controls.Add(destinationTxtBox);
            Controls.Add(destinationLbl);
            Controls.Add(btnSaveFile);
            Controls.Add(btnSelectFile);
            Controls.Add(titleLbl);
            Name = "FormToUppercase";
            Text = "FormToUppercase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button btnSelectFile;
        private Button btnSaveFile;
        private Label destinationLbl;
        private TextBox destinationTxtBox;
    }
}