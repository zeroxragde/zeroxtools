namespace winToolZeroX
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnOpenYoutube = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // btnOpenYoutube
            // 
            btnOpenYoutube.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenYoutube.ForeColor = SystemColors.ControlText;
            btnOpenYoutube.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenYoutube.ImageKey = "15707874.png";
            btnOpenYoutube.ImageList = imageList1;
            btnOpenYoutube.Location = new Point(23, 12);
            btnOpenYoutube.Name = "btnOpenYoutube";
            btnOpenYoutube.Size = new Size(203, 50);
            btnOpenYoutube.TabIndex = 0;
            btnOpenYoutube.Text = "DESCARGAR YOUTUBE";
            btnOpenYoutube.TextAlign = ContentAlignment.MiddleRight;
            btnOpenYoutube.UseVisualStyleBackColor = true;
            btnOpenYoutube.Click += btnOpenYoutube_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "15707874.png");
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(250, 450);
            Controls.Add(btnOpenYoutube);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZeroXTools";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenYoutube;
        private ImageList imageList1;
    }
}