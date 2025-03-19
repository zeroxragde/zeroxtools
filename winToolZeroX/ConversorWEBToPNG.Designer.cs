namespace winToolZeroX
{
    partial class ConversorWEBToPNG
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
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            cbAque = new ReaLTaiizor.Controls.HopeComboBox();
            cbDe = new ReaLTaiizor.Controls.HopeComboBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            btnCarpeta = new ReaLTaiizor.Controls.Button();
            btnArchivo = new ReaLTaiizor.Controls.Button();
            themeForm1.SuspendLayout();
            SuspendLayout();
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(cbAque);
            themeForm1.Controls.Add(cbDe);
            themeForm1.Controls.Add(bigLabel1);
            themeForm1.Controls.Add(metroControlBox1);
            themeForm1.Controls.Add(btnCarpeta);
            themeForm1.Controls.Add(btnArchivo);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = Properties.Resources.image_1186124;
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(348, 243);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.CenterParent;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "Convesor de Imagen";
            // 
            // cbAque
            // 
            cbAque.DrawMode = DrawMode.OwnerDrawFixed;
            cbAque.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAque.FlatStyle = FlatStyle.Flat;
            cbAque.Font = new Font("Segoe UI", 12F);
            cbAque.FormattingEnabled = true;
            cbAque.ItemHeight = 30;
            cbAque.Items.AddRange(new object[] { "WEB" });
            cbAque.Location = new Point(194, 74);
            cbAque.Name = "cbAque";
            cbAque.Size = new Size(131, 36);
            cbAque.TabIndex = 1;
            // 
            // cbDe
            // 
            cbDe.DrawMode = DrawMode.OwnerDrawFixed;
            cbDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDe.FlatStyle = FlatStyle.Flat;
            cbDe.Font = new Font("Segoe UI", 12F);
            cbDe.FormattingEnabled = true;
            cbDe.ItemHeight = 30;
            cbDe.Location = new Point(12, 73);
            cbDe.Name = "cbDe";
            cbDe.Size = new Size(131, 36);
            cbDe.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(143, 65);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(57, 46);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "->";
            bigLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // metroControlBox1
            // 
            metroControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox1.CloseHoverForeColor = Color.White;
            metroControlBox1.CloseNormalForeColor = Color.Gray;
            metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox1.DisabledForeColor = Color.DimGray;
            metroControlBox1.IsDerivedStyle = true;
            metroControlBox1.Location = new Point(248, 0);
            metroControlBox1.MaximizeBox = false;
            metroControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroControlBox1.MinimizeBox = true;
            metroControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroControlBox1.Name = "metroControlBox1";
            metroControlBox1.Size = new Size(100, 25);
            metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox1.StyleManager = null;
            metroControlBox1.TabIndex = 4;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // btnCarpeta
            // 
            btnCarpeta.BackColor = Color.Transparent;
            btnCarpeta.BorderColor = Color.White;
            btnCarpeta.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCarpeta.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCarpeta.Font = new Font("Microsoft Sans Serif", 12F);
            btnCarpeta.Image = null;
            btnCarpeta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarpeta.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCarpeta.Location = new Point(194, 149);
            btnCarpeta.Name = "btnCarpeta";
            btnCarpeta.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCarpeta.PressedColor = Color.FromArgb(165, 37, 37);
            btnCarpeta.Size = new Size(120, 63);
            btnCarpeta.TabIndex = 3;
            btnCarpeta.Text = "Carpeta";
            btnCarpeta.TextAlignment = StringAlignment.Center;
            btnCarpeta.Click += btnCarpeta_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.BackColor = Color.Transparent;
            btnArchivo.BorderColor = Color.White;
            btnArchivo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnArchivo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnArchivo.Font = new Font("Microsoft Sans Serif", 12F);
            btnArchivo.Image = null;
            btnArchivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchivo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnArchivo.Location = new Point(13, 149);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnArchivo.PressedColor = Color.FromArgb(165, 37, 37);
            btnArchivo.Size = new Size(120, 63);
            btnArchivo.TabIndex = 2;
            btnArchivo.Text = "Archivo";
            btnArchivo.TextAlignment = StringAlignment.Center;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // ConversorWEBToPNG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 243);
            Controls.Add(themeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "ConversorWEBToPNG";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Convesor de Imagen";
            TransparencyKey = Color.Fuchsia;
            themeForm1.ResumeLayout(false);
            themeForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.HopeComboBox cbDe;
        private ReaLTaiizor.Controls.Button btnArchivo;
        private ReaLTaiizor.Controls.HopeComboBox cbAque;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.Button btnCarpeta;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}