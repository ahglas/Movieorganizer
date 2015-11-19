using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class SelectFileToPlay : Form
    {
        private string _folder;
        private static DirectoryInfo _dirInfo;
        public SelectFileToPlay(string folder)
        {
            InitializeComponent();
            _folder = folder;
            _dirInfo = new DirectoryInfo(folder);
        }

        private void selectFileToPlay_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(_folder, "*", SearchOption.TopDirectoryOnly);
            List<string> videoFiles = new List<string>();
            foreach (var file in files)
            {
                if (file.EndsWith(".mp4"))
                {
                    videoFiles.Add(file);
                }
                if (file.EndsWith(".mkv"))
                {
                    videoFiles.Add(file);
                }
                if (file.EndsWith(".avi"))
                {
                    videoFiles.Add(file);
                }
            }
            foreach (var file in videoFiles)
            {
                int index = file.LastIndexOf("\\");
                string nfile = file.Substring(index + 1);
                listBox1.Items.Add(nfile);
            }
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                playFile(index);    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != null)
            {
                playFile(index);
            }
        }

        private void playFile(int index)
        {
            if (Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\VideoLAN\\VLC") != null)
            {
                string vlcLocation = (string)Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\VideoLAN\\VLC").GetValue("");
                var selectedVideoFile = '"' + "file:///" + _folder + "\\" + listBox1.SelectedItem + '"';
                selectedVideoFile = selectedVideoFile.Replace('\\', '/');
                Process.Start(vlcLocation, selectedVideoFile);
            }
            else if (Registry.LocalMachine.OpenSubKey("Software\\VideoLAN\\VLC") != null)
            {
                string vlcLocation = (string)Registry.LocalMachine.OpenSubKey("Software\\VideoLAN\\VLC").GetValue("");
                var selectedVideoFile = '"' + "file:///" + _folder + "\\" + listBox1.SelectedItem + '"';
                selectedVideoFile = selectedVideoFile.Replace('\\', '/');
                Process.Start(vlcLocation, selectedVideoFile);
            }
            else
            {
                var dialog = new error();
                dialog.ShowDialog();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
