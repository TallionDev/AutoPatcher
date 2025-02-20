/*******************************************************************************************
 * Sistem creat de Tallion, 2025
 * 
 * Website oficial: https://devm2code.com/
 * Discord: talion0127
 * Canal Discord: https://discord.gg/VZgzwacwFD
 * 
 * © Tallion 2025. Toate drepturile rezervate.
 *******************************************************************************************/
namespace Metin2Autopatcher
{
    partial class AutoPatcher
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private System.Windows.Forms.Timer backgroundTimer;
        private int currentBackgroundIndex = 0;
        private List<Image> backgrounds = new List<Image>();
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonConfig;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPatcher));
            buttonStart = new Button();
            buttonConfig = new Button();
            backgroundTimer = new System.Windows.Forms.Timer(components);
            labelFileName = new Label();
            ButtonPublisher = new Button();
            progressBar1 = new ProgressBar();
            buttonExit = new Button();
            buttonMinimize = new Button();
            doneaza = new Button();
            site = new Button();
            discord = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.WindowFrame;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonStart.ForeColor = Color.Ivory;
            buttonStart.ImeMode = ImeMode.NoControl;
            buttonStart.Location = new Point(13, 12);
            buttonStart.Margin = new Padding(4, 3, 4, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(99, 24);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonConfig
            // 
            buttonConfig.BackColor = SystemColors.WindowFrame;
            buttonConfig.BackgroundImageLayout = ImageLayout.Stretch;
            buttonConfig.FlatStyle = FlatStyle.Popup;
            buttonConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonConfig.ForeColor = Color.Ivory;
            buttonConfig.ImeMode = ImeMode.NoControl;
            buttonConfig.Location = new Point(13, 46);
            buttonConfig.Margin = new Padding(4, 3, 4, 3);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(99, 23);
            buttonConfig.TabIndex = 3;
            buttonConfig.Text = "CONFIG";
            buttonConfig.UseVisualStyleBackColor = false;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.BackColor = Color.FromArgb(180, 0, 0, 0);
            labelFileName.FlatStyle = FlatStyle.Flat;
            labelFileName.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFileName.ForeColor = Color.White;
            labelFileName.ImeMode = ImeMode.NoControl;
            labelFileName.Location = new Point(13, 214);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(80, 14);
            labelFileName.TabIndex = 7;
            labelFileName.Text = "Current file: -";
            labelFileName.Click += labelFileName_Click;
            // 
            // ButtonPublisher
            // 
            ButtonPublisher.BackColor = SystemColors.WindowFrame;
            ButtonPublisher.FlatStyle = FlatStyle.Popup;
            ButtonPublisher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonPublisher.ForeColor = Color.Ivory;
            ButtonPublisher.Location = new Point(12, 150);
            ButtonPublisher.Name = "ButtonPublisher";
            ButtonPublisher.Size = new Size(99, 24);
            ButtonPublisher.TabIndex = 10;
            ButtonPublisher.Text = "DEV";
            ButtonPublisher.UseVisualStyleBackColor = false;
            ButtonPublisher.Click += ButtonPublisher_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(249, 219);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(216, 10);
            progressBar1.TabIndex = 11;
            progressBar1.Click += progressBar1_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.WindowFrame;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.ForeColor = Color.Ivory;
            buttonExit.Location = new Point(432, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(33, 23);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "x";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = SystemColors.WindowFrame;
            buttonMinimize.FlatStyle = FlatStyle.Popup;
            buttonMinimize.ForeColor = Color.Ivory;
            buttonMinimize.Location = new Point(396, 2);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(33, 23);
            buttonMinimize.TabIndex = 13;
            buttonMinimize.Text = "-";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click_1;
            // 
            // doneaza
            // 
            doneaza.BackColor = SystemColors.WindowFrame;
            doneaza.FlatStyle = FlatStyle.Popup;
            doneaza.ForeColor = Color.Ivory;
            doneaza.Location = new Point(12, 180);
            doneaza.Name = "doneaza";
            doneaza.Size = new Size(99, 24);
            doneaza.TabIndex = 14;
            doneaza.Text = "DONATE";
            doneaza.UseVisualStyleBackColor = false;
            doneaza.Click += doneaza_Click;
            // 
            // site
            // 
            site.BackColor = SystemColors.WindowFrame;
            site.FlatStyle = FlatStyle.Popup;
            site.ForeColor = Color.Ivory;
            site.Location = new Point(13, 75);
            site.Name = "site";
            site.Size = new Size(99, 23);
            site.TabIndex = 15;
            site.Text = "SITE";
            site.UseVisualStyleBackColor = false;
            site.Click += site_Click;
            // 
            // discord
            // 
            discord.BackColor = SystemColors.WindowFrame;
            discord.FlatStyle = FlatStyle.Popup;
            discord.ForeColor = Color.Ivory;
            discord.Location = new Point(13, 104);
            discord.Name = "discord";
            discord.Size = new Size(99, 23);
            discord.TabIndex = 16;
            discord.Text = "DISCORD";
            discord.UseVisualStyleBackColor = false;
            discord.Click += discord_Click;
            // 
            // AutoPatcher
            // 
            AccessibleDescription = "StoryM2";
            AccessibleName = "StoryM2";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Autopatcher.Properties.Resources.bkr;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(467, 230);
            Controls.Add(discord);
            Controls.Add(site);
            Controls.Add(doneaza);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonExit);
            Controls.Add(progressBar1);
            Controls.Add(ButtonPublisher);
            Controls.Add(buttonConfig);
            Controls.Add(labelFileName);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AutoPatcher";
            RightToLeft = RightToLeft.No;
            Text = "StoryM2 @ Tallion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonPublisher;
        private ProgressBar progressBar1;
        private Button buttonExit;
        private Button buttonMinimize;
        private Button doneaza;
        private Button site;
        private Button discord;
    }
}
