namespace GrayscaleImageConverter
{
    partial class FormGrayscaleConverter
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
            FromDirBtn = new Button();
            ToDirBtn = new Button();
            ApplyFilterBtn = new Button();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(12, 22);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(333, 21);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Grayscale Filter to images from a directory";
            // 
            // FromDirBtn
            // 
            FromDirBtn.Location = new Point(12, 68);
            FromDirBtn.Name = "FromDirBtn";
            FromDirBtn.Size = new Size(166, 32);
            FromDirBtn.TabIndex = 1;
            FromDirBtn.Text = "Source Directory";
            FromDirBtn.UseVisualStyleBackColor = true;
            FromDirBtn.Click += FromDirBtn_Click;
            // 
            // ToDirBtn
            // 
            ToDirBtn.Location = new Point(184, 68);
            ToDirBtn.Name = "ToDirBtn";
            ToDirBtn.Size = new Size(161, 30);
            ToDirBtn.TabIndex = 2;
            ToDirBtn.Text = "Destination Directory";
            ToDirBtn.UseVisualStyleBackColor = true;
            ToDirBtn.Click += ToDirBtn_Click;
            // 
            // ApplyFilterBtn
            // 
            ApplyFilterBtn.Enabled = false;
            ApplyFilterBtn.Location = new Point(12, 120);
            ApplyFilterBtn.Name = "ApplyFilterBtn";
            ApplyFilterBtn.Size = new Size(333, 47);
            ApplyFilterBtn.TabIndex = 3;
            ApplyFilterBtn.Text = "Apply Filter";
            ApplyFilterBtn.UseVisualStyleBackColor = true;
            ApplyFilterBtn.Click += ApplyFilterBtn_Click;
            // 
            // FormGrayscaleConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 450);
            Controls.Add(ApplyFilterBtn);
            Controls.Add(ToDirBtn);
            Controls.Add(FromDirBtn);
            Controls.Add(titleLbl);
            Name = "FormGrayscaleConverter";
            Text = "FormGrayscaleConverter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button FromDirBtn;
        private Button ToDirBtn;
        private Button ApplyFilterBtn;
    }
}