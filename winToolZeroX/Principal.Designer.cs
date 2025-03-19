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
            imageList1 = new ImageList(components);
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            parrotSuperButton2 = new ReaLTaiizor.Controls.ParrotSuperButton();
            parrotSuperButton1 = new ReaLTaiizor.Controls.ParrotSuperButton();
            themeForm1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "15707874.png");
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(cyberButton1);
            themeForm1.Controls.Add(parrotSuperButton2);
            themeForm1.Controls.Add(parrotSuperButton1);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = Properties.Resources.zeroxtools_icon_1;
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(261, 450);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.CenterScreen;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "ZeroXTools";
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(0, 0, 64);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.Red;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(67, 388);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(130, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 2;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "CERRAR";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // parrotSuperButton2
            // 
            parrotSuperButton2.BackgroundColor = Color.Black;
            parrotSuperButton2.ButtonImage = Properties.Resources.image_1186124;
            parrotSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton2.ButtonText = "CONVERSOR IMAGEN";
            parrotSuperButton2.CornerRadius = 20;
            parrotSuperButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton2.HoverBackgroundColor = Color.Silver;
            parrotSuperButton2.HoverTextColor = Color.Black;
            parrotSuperButton2.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton2.Location = new Point(18, 142);
            parrotSuperButton2.Name = "parrotSuperButton2";
            parrotSuperButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton2.SelectedBackColor = Color.LimeGreen;
            parrotSuperButton2.SelectedTextColor = Color.White;
            parrotSuperButton2.Size = new Size(210, 40);
            parrotSuperButton2.SuperSelected = false;
            parrotSuperButton2.TabIndex = 1;
            parrotSuperButton2.TextColor = Color.White;
            parrotSuperButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton2.Vertical_Alignment = StringAlignment.Center;
            parrotSuperButton2.Click += parrotSuperButton2_Click;
            // 
            // parrotSuperButton1
            // 
            parrotSuperButton1.BackgroundColor = Color.Black;
            parrotSuperButton1.ButtonImage = Properties.Resources._15707874;
            parrotSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton1.ButtonText = "DESCARGAR YOUTUBE";
            parrotSuperButton1.CornerRadius = 20;
            parrotSuperButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton1.HoverBackgroundColor = Color.Silver;
            parrotSuperButton1.HoverTextColor = Color.Black;
            parrotSuperButton1.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton1.Location = new Point(18, 73);
            parrotSuperButton1.Name = "parrotSuperButton1";
            parrotSuperButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton1.SelectedBackColor = Color.LimeGreen;
            parrotSuperButton1.SelectedTextColor = Color.White;
            parrotSuperButton1.Size = new Size(210, 40);
            parrotSuperButton1.SuperSelected = false;
            parrotSuperButton1.TabIndex = 0;
            parrotSuperButton1.TextColor = Color.White;
            parrotSuperButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton1.Vertical_Alignment = StringAlignment.Center;
            parrotSuperButton1.Click += parrotSuperButton1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(261, 450);
            Controls.Add(themeForm1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(261, 61);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZeroXTools";
            TransparencyKey = Color.Fuchsia;
            themeForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton1;
        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton2;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}