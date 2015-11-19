using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ImageSelection : Form
    {
        private string background, profile;
        public ImageSelection()
        {
            InitializeComponent();
            profileFileName.Text = Properties.Settings.Default.ProfilePicturePath;
            profile = profileFileName.Text;
            backgroundFileName.Text = Properties.Settings.Default.BackgroundPicturePath;
            background = backgroundFileName.Text;
        }

        private void openProfilePicker_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult res = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (res == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName.ToString();
                profileFileName.Text = fileName;
                profile = fileName;
            }
        }

        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void openBackgroundPicker_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult res = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (res == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName.ToString();
                backgroundFileName.Text = fileName;
                background = fileName;
            }
        }

        private void profileFileName_TextChanged(object sender, EventArgs e)
        {
            profile = profileFileName.Text;
        }

        private void backgroundFileName_TextChanged(object sender, EventArgs e)
        {
            background = backgroundFileName.Text;
        }

        public string getProfilePicture()
        {
            return this.profile == "" ? null : this.profile;
        }
        public string getBackground()
        {
            return this.background== "" ? null : this.background;
        }
    }
}
