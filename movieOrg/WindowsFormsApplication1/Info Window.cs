using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Info_Window : Form
    {
        private string folder;
        private string _title, _year, _story, _genre;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileToPlay(folder);
            dialog.ShowDialog();
        }

        public Info_Window(String test)
        {
            InitializeComponent();
            folder = test;
        }

        private void Info_Window_Load(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = null;
            var files = Directory.GetFiles(folder, "*.nfo", SearchOption.TopDirectoryOnly);
            if (files.Length == 1)
            {
                reader = XmlReader.Create(files[0], settings);
            }
            else
            {
                MessageBox.Show("This movie/serie is not identified yet");
                return;
            }
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "title":
                            if (reader.Read())
                            {
                                labelTitle.Text = reader.Value;
                            }
                            break;
                        case "year":
                            if (reader.Read())
                            {
                                labelYear.Text = reader.Value;
                            }
                            break;
                        case "plot":
                            if (reader.Read())
                            {
                                textBoxStory.Text = reader.Value;
                            }
                            break;
                        case "genre":
                            if (reader.Read())
                            {
                                _genre += reader.Value + ", ";
                            }
                            break;
                        case "actor":
                            if (reader.Read())
                            {
                                Console.WriteLine(reader.Value);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            textBoxGenres.Text = _genre.Substring(0, _genre.Length-2);
            poster_path.Load(folder + "\\cover.jpg");
        }
    }
}
