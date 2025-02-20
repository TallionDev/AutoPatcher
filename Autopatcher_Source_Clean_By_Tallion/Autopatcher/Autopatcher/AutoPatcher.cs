/*******************************************************************************************
 * Sistem creat de Tallion, 2025
 * 
 * Website oficial: https://devm2code.com/
 * Discord: talion0127
 * Canal Discord: https://discord.gg/VZgzwacwFD
 * 
 * © Tallion 2025. Toate drepturile rezervate.
 *******************************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin2Autopatcher
{
    public partial class AutoPatcher : Form
    {
        private const string PatchServerURL = "http://patcher.storym2.ro/patch/";
        private string siteURL = "https://www.devm2code.com/";
        private string discordURL = "https://discord.gg/nWGCbBHa";
        private string exeFileName = "Metin2Distribute.exe";
        private string configFileName = "config.exe";
        private const string PatchlistName = "patchlist.txt";
        private static readonly HttpClient httpClient = new HttpClient();
        private string patchlistPath;
        private bool mouseDown;
        private Point lastLocation;

        public AutoPatcher()
        {
            InitializeComponent();
            StartDownloadProcess();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private async void StartDownloadProcess()
        {
            try
            {
                patchlistPath = Path.Combine(Application.StartupPath, PatchlistName);
                await DownloadFileAsync(PatchServerURL + PatchlistName, patchlistPath);

                bool clientModified = await CheckAndDownloadModifiedFiles();

                if (clientModified)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Download error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task<bool> CheckAndDownloadModifiedFiles()
        {
            bool clientModified = false;
            var downloadTasks = new List<Task>();

            foreach (string line in File.ReadLines(patchlistPath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');
                if (parts.Length != 2) continue;

                string relativeFilePath = parts[0].Trim();
                string expectedHash = parts[1].Trim();
                string localFilePath = Path.Combine(Application.StartupPath, relativeFilePath);

                Directory.CreateDirectory(Path.GetDirectoryName(localFilePath));

                if (!File.Exists(localFilePath) || ComputeFileHash(localFilePath) != expectedHash)
                {
                    clientModified = true;
                    downloadTasks.Add(DownloadFileAsync(PatchServerURL + relativeFilePath, localFilePath));
                }
            }

            await Task.WhenAll(downloadTasks);
            return clientModified;
        }

        private async Task<bool> DownloadFileAsync(string fileUrl, string localFilePath, int maxRetries = 3)
        {
            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    using (var response = await httpClient.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();
                        long totalBytes = response.Content.Headers.ContentLength ?? -1;
                        long totalBytesDownloaded = 0;

                        string fileName = Path.GetFileName(localFilePath);
                        labelFileName.Invoke(new Action(() => labelFileName.Text = $"Download: {fileName}"));

                        progressBar1.Invoke(new Action(() =>
                        {
                            progressBar1.Value = 0;
                            progressBar1.Maximum = 100;
                        }));

                        using (var fileStream = new FileStream(localFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                        using (var contentStream = await response.Content.ReadAsStreamAsync())
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;

                            while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await fileStream.WriteAsync(buffer, 0, bytesRead);
                                totalBytesDownloaded += bytesRead;

                                if (totalBytes > 0)
                                {
                                    int progress = (int)((totalBytesDownloaded * 100) / totalBytes);
                                    progressBar1.Invoke(new Action(() => progressBar1.Value = progress));
                                }
                            }
                        }

                        return true;
                    }
                }
                catch when (attempt < maxRetries)
                {
                    await Task.Delay(500);
                }
            }

            MessageBox.Show($"Failed to download {Path.GetFileName(localFilePath)} after {maxRetries} attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }



        private string ComputeFileHash(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
            {
                byte[] hashBytes = sha256.ComputeHash(stream);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(exeFileName))
                {
                    MessageBox.Show("Launcher not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exeFileName,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                if (ex.NativeErrorCode == 1223)
                {
                    //MessageBox.Show("Launch was canceled by the user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error starting the launcher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error starting the launcher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void buttonConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string configPath = Path.Combine(Application.StartupPath, configFileName);
                if (File.Exists(configPath))
                {
                    Process.Start(configPath);
                }
                else
                {
                    MessageBox.Show($"{configFileName} was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening {configFileName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonPublisher_Click_1(object sender, EventArgs e)
        {
            Form publisherForm = new Form
            {
                Text = "About AutoPatcher",
                Size = new Size(450, 410),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            RichTextBox richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                DetectUrls = true,
                Text =
                    "Publisher: @Tallion \n" +
                    "Contact: https://devm2code.com/index.php/contact-us/\n" +
                    "Discord: https://discord.gg/VZgzwacwFD\n" +
                    "Website: https://devm2code.com/\n" +
                    "© 2025 Tallion. All rights reserved.\n" +
                    "Version: 1.0.0\n" +
                    "Terms: https://devm2code.com/index.php/terms-and-conditions/\n\n" +
                    "***This is a FREE version of AutoPatcher.***\n" +
                    "For a more advanced and secure version, we offer:\n\n" +
                    "🔒 **AES-256 Encryption** - Protects files with military-grade encryption.\n" +
                    "🛡 **In-Memory Execution** - The launcher runs directly in memory, without being written to disk,\n" +
                    "     preventing unauthorized modifications and reverse engineering.\n" +
                    "🚫 **Anti-Tampering Protection** - Blocks attempts to modify or replace the launcher.\n" +
                    "🎮 **Built-in Anti-Cheat System** - Detects and blocks hacking tools such as Cheat Engine,\n" +
                    "     Process Hacker, and other unauthorized software.\n\n" +
                    "If you are interested in a private, secured version with advanced protection and custom features,\n" +
                    "please contact us."
            };

            richTextBox.LinkClicked += (s, args) =>
            {
                Process.Start(new ProcessStartInfo(args.LinkText) { UseShellExecute = true });
            };

            publisherForm.Controls.Add(richTextBox);
            publisherForm.ShowDialog();
        }




        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void labelFileName_Click(object sender, EventArgs e)
        {

        }
        private void doneaza_Click(object sender, EventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://paypal.me/ionelvasilache?country.x=FR&locale.x=en_US",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the donation link: " + ex.Message);
            }
        }

        private void site_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = siteURL,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open the website!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void discord_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = discordURL,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open the Discord link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) => (mouseDown, lastLocation) = (true, e.Location);
        private void Form1_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { this.Location = new Point(this.Location.X - lastLocation.X + e.X, this.Location.Y - lastLocation.Y + e.Y); this.Update(); } }
        private void Form1_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;


    }
}
