using System.Diagnostics;
using YoutubeExplode;

namespace winToolZeroX
{
    public partial class Form1 : Form
    {
        string savedPath = Properties.Settings.Default.DownloadPath;
        YoutubeClient youtube = new YoutubeClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            saveYotube();
        }
        private void setFolder()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // Establecer la carpeta inicial si ya está seleccionada
                if (!string.IsNullOrEmpty(Properties.Settings.Default.DownloadPath) &&
                    Directory.Exists(Properties.Settings.Default.DownloadPath))
                {
                    folderDialog.SelectedPath = Properties.Settings.Default.DownloadPath;
                }

                folderDialog.Description = "Selecciona la carpeta donde guardar los videos descargados";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Guardar la ruta seleccionada en la configuración
                    Properties.Settings.Default.DownloadPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();

                    // Actualizar el Label para mostrar la ruta seleccionada
                    labelFolderPath.Text = $"Ruta de Guardado: {folderDialog.SelectedPath}";
                }
            }
        }

        private async void saveYotube(bool isOnlyAudio = false)
        {
            string videoUrl = txtYoutubeLink.Text.Trim();

            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Por favor, ingresa una URL de YouTube válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si se ha seleccionado una carpeta de descarga
            string downloadPath = Properties.Settings.Default.DownloadPath;
            if (string.IsNullOrEmpty(downloadPath) || !Directory.Exists(downloadPath))
            {
                DialogResult result = MessageBox.Show("No se ha seleccionado una carpeta de descarga. ¿Deseas seleccionar una ahora?", "Seleccionar Carpeta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    setFolder(); // Invocar el método para seleccionar carpeta
                    downloadPath = Properties.Settings.Default.DownloadPath;
                    if (string.IsNullOrEmpty(downloadPath) || !Directory.Exists(downloadPath))
                    {
                        MessageBox.Show("No se seleccionó una carpeta de descarga. No se puede proceder con la descarga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó una carpeta de descarga. No se puede proceder con la descarga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            labelStatus.Text = "Obteniendo información del video...";
            progressBar.Value = 0;
            try
            {
                var youtube = new YoutubeClient();


                // Actualizar el estado
                labelStatus.Text = "Obteniendo información del video...";
                var video = await youtube.Videos.GetAsync(videoUrl);
                // Obtener el manifiesto de streams
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);

                // Obtener el mejor stream de video
                var videoStreamInfo = streamManifest.GetVideoStreams()
                                                     .OrderByDescending(s => s.VideoQuality.MaxHeight)
                                                     .FirstOrDefault();

                // Obtener el mejor stream de audio
                var audioStreamInfo = streamManifest.GetAudioStreams()
                                                     .OrderByDescending(s => s.Bitrate)
                                                     .FirstOrDefault();

                if (videoStreamInfo == null || audioStreamInfo == null)
                {
                    labelStatus.Text = "No se encontraron streams de video o audio.";
                    return;
                }

                // Rutas de los archivos
                var tempVideoPath = Path.Combine(downloadPath, "temp_video.mp4");
                var tempAudioPath = Path.Combine(downloadPath, "temp_audio.mp4");
                var combinedOutputPath = Path.Combine(downloadPath, "video_combinado.mp4");

                // Configurar ProgressBar
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                // Crear rastreador de progreso
                var progressHandler = new Progress<double>(progress =>
                {
                    this.Invoke(new Action(() =>
                    {
                        progressBar.Value = (int)(progress * 100); // Actualizar barra de progreso
                    }));
                });

                if (!isOnlyAudio)
                {
                    // Descargar el stream de video
                    labelStatus.Text = "Descargando video...";
                    await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, tempVideoPath, progressHandler);
                    labelStatus.Text = $"Video descargado en: {tempVideoPath}";
                }


                // Descargar el stream de audio
                labelStatus.Text = "Descargando audio...";
                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, tempAudioPath, progressHandler);
                labelStatus.Text = $"Audio descargado en: {tempAudioPath}";
                if (!isOnlyAudio)
                {
                    // Combinar video y audio
                    combinedOutputPath = Path.Combine(downloadPath, video.Title.Trim() + ".mp4");
                    labelStatus.Text = "Combinando video y audio...";
                    CombineAudioVideo(tempVideoPath, tempAudioPath, combinedOutputPath);
                    labelStatus.Text = $"Archivo combinado guardado en: {combinedOutputPath}";
                }

                if (!isOnlyAudio) {
                  
                    if (File.Exists(tempAudioPath))
                        File.Delete(tempAudioPath);
                }
                else
                {
                    ConvertToMp3(tempAudioPath, Path.Combine(downloadPath, video.Title.Trim() + ".mp3"));
                    combinedOutputPath = Path.Combine(downloadPath, video.Title.Trim() + ".mp3");
                }
                
                // Eliminar archivos temporales
                if (File.Exists(tempVideoPath))
                File.Delete(tempVideoPath);



                labelStatus.Text = "Proceso completado exitosamente.";
                MessageBox.Show($"El archivo combinado se ha guardado correctamente en la ruta: {combinedOutputPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Ocurrió un error durante la operación.";
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0; // Reiniciar la barra de progreso
            }

        }//FIN DE METODO


        private void ConvertToMp3(string inputPath, string outputPath)
        {
            // Ruta relativa al ejecutable de FFmpeg dentro de la carpeta "ffmpeg"
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\bin", "ffmpeg.exe");

            // Verificar que el archivo ffmpeg.exe exista
            if (!File.Exists(ffmpegPath))
            {
                throw new FileNotFoundException("No se encontró ffmpeg.exe en la carpeta 'ffmpeg'.");
            }

            // Verificar que el archivo de entrada exista
            if (!File.Exists(inputPath))
            {
                throw new FileNotFoundException($"No se encontró el archivo de entrada: {inputPath}");
            }

            // Comando para convertir el archivo MP4 a MP3
            var arguments = $"-i \"{inputPath}\" -vn -acodec libmp3lame -q:a 2 \"{outputPath}\"";

            // Configurar el proceso de FFmpeg
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            try
            {
                process.Start();

                // Leer la salida estándar y de error de FFmpeg para depurar
                string standardOutput = process.StandardOutput.ReadToEnd();
                string standardError = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // Verificar el código de salida de FFmpeg
                if (process.ExitCode != 0)
                {
                    throw new Exception($"FFmpeg Error: {standardError}");
                }

                Console.WriteLine($"Conversión completada con éxito: {standardOutput}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error durante la conversión a MP3 con FFmpeg: {ex.Message}");
            }
            if (File.Exists(inputPath))
                File.Delete(inputPath);
        }
        private void CombineAudioVideo(string videoPath, string audioPath, string outputPath)
        {
            // Ruta al ejecutable de FFmpeg (asegúrate de que FFmpeg esté en el PATH del sistema)
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\bin", "ffmpeg.exe");

            // Comando para combinar audio y video
            var arguments = $"-i \"{videoPath}\" -i \"{audioPath}\" -c:v copy -c:a aac -strict experimental \"{outputPath}\"";

            // Configurar el proceso de FFmpeg
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            // Leer la salida del proceso (opcional, para depuración)
            while (!process.StandardError.EndOfStream)
            {
                string line = process.StandardError.ReadLine();
                // Actualizar estado para mostrar progreso de FFmpeg
                this.Invoke(new Action(() =>
                {
                    labelStatus.Text = $"FFmpeg: {line}";
                }));
            }

            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception("Ocurrió un error al combinar el video y el audio con FFmpeg.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string savedPath = Properties.Settings.Default.DownloadPath;
            if (!string.IsNullOrEmpty(savedPath) && Directory.Exists(savedPath))
            {
                labelFolderPath.Text = $"Ruta de Guardado: {savedPath}";
            }
            else
            {
                labelFolderPath.Text = "Ruta de Guardado: No seleccionada";
            }
        }

        private void btnChangeDir_Click(object sender, EventArgs e)
        {
            setFolder();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            saveYotube(true);
        }
    }
}
