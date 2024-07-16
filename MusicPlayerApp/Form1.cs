namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelLogo_Click(object sender, EventArgs e)
        {

        }

        private void LBLfooter_Click(object sender, EventArgs e)
        {

        }

        // Global string types array variables to save name and path of the track
        String[] path, files;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to close the app
            this.Close();
        }

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Saving the names of the tracks in files array
                path = ofd.FileNames; // Save the paths of the tracks in path array

                // Display the songs titles in ListBox
                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(files[i]); // Display song in listBox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play the Music selected
            axWindowsMediaPlayerMusic.URL = path[ListBoxSongs.SelectedIndex];
        }
    }
}
