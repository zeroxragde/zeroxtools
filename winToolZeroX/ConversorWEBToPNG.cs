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

namespace winToolZeroX
{
    public partial class ConversorWEBToPNG : Form
    {
        string[] formatos = new string[]
         {
            "PNG",
            "JPEG",
            "JPG",
            "GIF",
            "BMP",
            "TIFF",
            "WebP",
            "SVG",
            "HEIF",
            "ICO",
            "EPS",
            "PSD",
            "PDF",
            "RAW",
            "AVIF"
         };

        public ConversorWEBToPNG()
        {
            InitializeComponent();
            cbDe.Items.AddRange(formatos);
            cbAque.Items.AddRange(formatos);
            cbDe.SelectedIndex = 6;
            cbAque.SelectedIndex = 1;
        }

        private static void ConvertWebPToPng(string inputPath, string outputPath)
        {
            using (var image = new MagickImage(inputPath))
            {
                image.Format = MagickFormat.Png;
                image.Write(outputPath);
            }
        }
        // Método para convertir WebP a PNG
        private static void ConvertImage(string inputPath, string outputPath, MagickFormat outputFormat)
        {
            using (var image = new MagickImage(inputPath))
            {
                image.Format = outputFormat;
                image.Write(outputPath);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecciona un archivo para convertir",
                Filter = "Imagenes soportadas (*.webp;*.jpg;*.jpeg;*.png;*.gif)|*.webp;*.jpg;*.jpeg;*.png;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string outputPath = sourcePath;

                // Verificar los valores seleccionados en los ComboBox
                string inputFormat = cbDe.SelectedItem.ToString();
                string outputFormat = cbAque.SelectedItem.ToString();

                // Comprobar si el formato de entrada y salida coinciden
                if (inputFormat == outputFormat)
                {
                    MessageBox.Show("El formato de entrada y salida no puede ser el mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar el nuevo nombre para el archivo de salida
                outputPath = outputPath.Replace(System.IO.Path.GetExtension(sourcePath), $".{outputFormat.ToLower()}");

                // Convertir dependiendo del formato seleccionado
                if (inputFormat == "WebP" && outputFormat == "PNG")
                {
                    ConvertImage(sourcePath, outputPath, MagickFormat.Png);
                    MessageBox.Show($"Archivo convertido con éxito a PNG y guardado en: {outputPath}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inputFormat == "JPEG" && outputFormat == "PNG")
                {
                    ConvertImage(sourcePath, outputPath, MagickFormat.Png);
                    MessageBox.Show($"Archivo convertido con éxito a PNG y guardado en: {outputPath}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inputFormat == "PNG" && outputFormat == "JPEG")
                {
                    ConvertImage(sourcePath, outputPath, MagickFormat.Jpeg);
                    MessageBox.Show($"Archivo convertido con éxito a JPEG y guardado en: {outputPath}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La conversión no está soportada entre estos formatos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Selecciona una carpeta con imágenes para convertir"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                string outputFolder = selectedFolder + "_Converted"; // Carpeta para guardar las imágenes convertidas

                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                string inputFormat = cbDe.SelectedItem.ToString();
                string outputFormat = cbAque.SelectedItem.ToString();

                // Filtrar los archivos de la carpeta con el formato seleccionado
                string[] files = Directory.GetFiles(selectedFolder, $"*.{inputFormat.ToLower()}");

                foreach (string file in files)
                {
                    string outputPath = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(file) + $".{outputFormat.ToLower()}");

                    // Convertir cada archivo
                    try
                    {
                        if (inputFormat == "WebP" && outputFormat == "PNG")
                        {
                            ConvertImage(file, outputPath, MagickFormat.Png);
                        }
                        else if (inputFormat == "JPEG" && outputFormat == "PNG")
                        {
                            ConvertImage(file, outputPath, MagickFormat.Png);
                        }
                        else if (inputFormat == "PNG" && outputFormat == "JPEG")
                        {
                            ConvertImage(file, outputPath, MagickFormat.Jpeg);
                        }
                        else
                        {
                            MessageBox.Show($"La conversión de {file} no está soportada entre estos formatos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al convertir el archivo {file}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Conversión de la carpeta completada.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna carpeta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //////////////////////////////////////////
    }
}
