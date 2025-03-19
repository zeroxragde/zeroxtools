namespace winToolZeroX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtYoutubeLink = new TextBox();
            label1 = new Label();
            btnDescarga = new Button();
            button2 = new Button();
            labelFolderPath = new Label();
            labelStatus = new Label();
            progressBar = new ProgressBar();
            btnChangeDir = new Button();
            SuspendLayout();
            // 
            // txtYoutubeLink
            // 
            txtYoutubeLink.Location = new Point(13, 35);
            txtYoutubeLink.Margin = new Padding(4);
            txtYoutubeLink.Name = "txtYoutubeLink";
            txtYoutubeLink.Size = new Size(566, 26);
            txtYoutubeLink.TabIndex = 0;
            txtYoutubeLink.Text = "https://www.youtube.com/watch?v=RgBKfuf8Wp0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 1;
            label1.Text = "Youtube URL";
            // 
            // btnDescarga
            // 
            btnDescarga.ForeColor = SystemColors.ActiveCaptionText;
            btnDescarga.Location = new Point(13, 91);
            btnDescarga.Name = "btnDescarga";
            btnDescarga.Size = new Size(107, 31);
            btnDescarga.TabIndex = 2;
            btnDescarga.Text = "Descargar";
            btnDescarga.UseVisualStyleBackColor = true;
            btnDescarga.Click += btnDescarga_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(137, 91);
            button2.Name = "button2";
            button2.Size = new Size(148, 31);
            button2.TabIndex = 3;
            button2.Text = "Descargar MP3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // labelFolderPath
            // 
            labelFolderPath.BackColor = Color.Black;
            labelFolderPath.Location = new Point(13, 65);
            labelFolderPath.Name = "labelFolderPath";
            labelFolderPath.Size = new Size(566, 19);
            labelFolderPath.TabIndex = 4;
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Maroon;
            labelStatus.ImageAlign = ContentAlignment.BottomCenter;
            labelStatus.Location = new Point(299, 91);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(280, 78);
            labelStatus.TabIndex = 5;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(21, 196);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(559, 23);
            progressBar.TabIndex = 6;
            // 
            // btnChangeDir
            // 
            btnChangeDir.ForeColor = SystemColors.ActiveCaptionText;
            btnChangeDir.Location = new Point(40, 128);
            btnChangeDir.Name = "btnChangeDir";
            btnChangeDir.Size = new Size(175, 31);
            btnChangeDir.TabIndex = 7;
            btnChangeDir.Text = "Cambiar Carpeta";
            btnChangeDir.UseVisualStyleBackColor = true;
            btnChangeDir.Click += btnChangeDir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(592, 231);
            Controls.Add(btnChangeDir);
            Controls.Add(progressBar);
            Controls.Add(labelStatus);
            Controls.Add(labelFolderPath);
            Controls.Add(button2);
            Controls.Add(btnDescarga);
            Controls.Add(label1);
            Controls.Add(txtYoutubeLink);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZeroXTools - Youtube";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYoutubeLink;
        private Label label1;
        private Button btnDescarga;
        private Button button2;
        private Label labelFolderPath;
        private Label labelStatus;
        private ProgressBar progressBar;
        private Button btnChangeDir;
    }
}
