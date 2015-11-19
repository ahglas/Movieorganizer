using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SelectMovieFolder : Form
    {
        private string _selectedFolder;

        public SelectMovieFolder()
        {
            InitializeComponent();
            var myVideosFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            var baseDir = Properties.Settings.Default.baseDir;
            radioButton1.Text = myVideosFolder;
            textBox1.Text = baseDir;
            if(!baseDir.Equals(myVideosFolder))
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            var dialog = new FolderBrowserDialog();
            dialog.Description = "Select your movie folder";
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                _selectedFolder = dialog.SelectedPath;
            }
        }

        public string GetSelectedFolder()
        {
            return _selectedFolder;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                _selectedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            }
            if (radioButton2.Checked)
            {
                _selectedFolder = textBox1.Text;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
