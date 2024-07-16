namespace MusicPlayerApp
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            LabelLogo = new Label();
            pictureBox1 = new PictureBox();
            ListBoxSongs = new ListBox();
            BtnSelectSongs = new Button();
            axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            LBLfooter = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Anchor = AnchorStyles.Top;
            TopPanel.BackColor = Color.LightSkyBlue;
            TopPanel.Controls.Add(LabelLogo);
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Location = new Point(1, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(922, 58);
            TopPanel.TabIndex = 0;
            // 
            // LabelLogo
            // 
            LabelLogo.AutoSize = true;
            LabelLogo.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLogo.ForeColor = Color.White;
            LabelLogo.Location = new Point(349, 9);
            LabelLogo.Name = "LabelLogo";
            LabelLogo.Size = new Size(155, 20);
            LabelLogo.TabIndex = 0;
            LabelLogo.Text = "Music Player App";
            LabelLogo.Click += LabelLogo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(886, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ListBoxSongs
            // 
            ListBoxSongs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxSongs.FormattingEnabled = true;
            ListBoxSongs.ItemHeight = 23;
            ListBoxSongs.Location = new Point(691, 41);
            ListBoxSongs.Name = "ListBoxSongs";
            ListBoxSongs.Size = new Size(219, 395);
            ListBoxSongs.TabIndex = 2;
            ListBoxSongs.SelectedIndexChanged += ListBoxSongs_SelectedIndexChanged;
            // 
            // BtnSelectSongs
            // 
            BtnSelectSongs.BackColor = Color.LightSkyBlue;
            BtnSelectSongs.FlatStyle = FlatStyle.Flat;
            BtnSelectSongs.ForeColor = Color.White;
            BtnSelectSongs.Location = new Point(733, 442);
            BtnSelectSongs.Name = "BtnSelectSongs";
            BtnSelectSongs.Size = new Size(137, 44);
            BtnSelectSongs.TabIndex = 3;
            BtnSelectSongs.Text = "Select Songs";
            BtnSelectSongs.UseVisualStyleBackColor = false;
            BtnSelectSongs.Click += BtnSelectSongs_Click;
            // 
            // axWindowsMediaPlayerMusic
            // 
            axWindowsMediaPlayerMusic.Enabled = true;
            axWindowsMediaPlayerMusic.Location = new Point(1, 41);
            axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            axWindowsMediaPlayerMusic.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayerMusic.OcxState");
            axWindowsMediaPlayerMusic.Size = new Size(684, 439);
            axWindowsMediaPlayerMusic.TabIndex = 4;
            // 
            // LBLfooter
            // 
            LBLfooter.AutoSize = true;
            LBLfooter.Location = new Point(12, 505);
            LBLfooter.Name = "LBLfooter";
            LBLfooter.Size = new Size(192, 20);
            LBLfooter.TabIndex = 5;
            LBLfooter.Text = "Developed by Backender ®";
            LBLfooter.Click += LBLfooter_Click;
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 534);
            Controls.Add(LBLfooter);
            Controls.Add(axWindowsMediaPlayerMusic);
            Controls.Add(BtnSelectSongs);
            Controls.Add(ListBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App ";
            Load += Form1_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label LabelLogo;
        private PictureBox pictureBox1;
        private ListBox ListBoxSongs;
        private Button BtnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private Label LBLfooter;
    }
}
