using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using RestSharp.Extensions;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.TvShows;
using TVDBSharp;
using TVDBSharp.Models;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        TMDbClient client = new TMDbClient("a8fab4f9461636422a8df05bf17065a8");
        private Movie movie;
        private string currentDir;
        private string lastDir;
        private string baseDir;
        protected static string _tvDBApiKey = "D006A38E5EF5852B";
        TVDB tvdb = new TVDB(_tvDBApiKey);

        public Form1()
        {
            InitializeComponent();
            currentDir = baseDir;
            MovieBox.DrawMode = DrawMode.OwnerDrawFixed;
            MovieBox.DrawItem += drawItems;

            string background = Settings.Default.BackgroundPicturePath;
            string profilepic = Settings.Default.ProfilePicturePath;
            baseDir = Settings.Default.baseDir;
            if (background.Length != 0) {
                BackgroundImage = new Bitmap(background);
            }
            if (profilepic.Length != 0)
            {
                profilePicture.Image = new Bitmap(profilepic);
            }
            else
                profilePicture.Visible = false;
        }

        private void drawItems(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            
            int i = e.Index;
            if (i != -1)
            {

                Font myFont;
                Brush myBrush;
                string dir = currentDir + "\\" + MovieBox.Items[i];
                
                string[] content = Directory.GetFiles(dir, "*.nfo", SearchOption.TopDirectoryOnly);
                if (content.Length == 0 && i != 0)
                {
                    myFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                    myBrush = Brushes.Red;
                }
                else
                {
                    myFont = e.Font;
                    myBrush = Brushes.Black;
                }

                e.Graphics.DrawString(MovieBox.Items[i].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            }

        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bool noBaseDir = baseDir == "" || !Directory.Exists(baseDir);

            if (noBaseDir)
            {
                var dialog = new SelectMovieFolder();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.baseDir = dialog.GetSelectedFolder();
                    Properties.Settings.Default.Save();
                    baseDir = dialog.GetSelectedFolder();
                }
            }
            getDirs(baseDir);
            currentDir = baseDir;
        }

        private void openDirButton_Click(object sender, EventArgs e)
        {
            if (MovieBox.SelectedIndex == 0)
            {
                int index = lastDir.LastIndexOf('\\');
                currentDir = lastDir.Remove(index);
                getDirs(currentDir);

            }
            else
            {
                currentDir = currentDir + "\\" + MovieBox.SelectedItem;
                getDirs(currentDir);
            }
        }
        private void getDirs(string searchDir)
        {
            lastDir = searchDir;
            MovieBox.Items.Clear();
            string[] dirs = Directory.GetDirectories(searchDir, "*", SearchOption.TopDirectoryOnly);
            MovieBox.Items.Add("..\\");
            foreach (string dir in dirs)
            {
                
                int index = dir.LastIndexOf("\\");
                string ndir = dir.Substring(index + 1);
                MovieBox.Items.Add(ndir);
                MovieBox.DrawItem += drawItems;
            }
            
            Console.WriteLine(searchDir);
        }

        private void findMovieButton_Click(object sender, EventArgs e)
        {
            String searchString = getUsableSearchString(MovieBox.SelectedItem.ToString());
            FindMovie(searchString);
        }

        private void findSerieButton_Click(object sender, EventArgs e)
        {
            String searchString = getUsableSearchString(MovieBox.SelectedItem.ToString());
            findTvDBSeries(searchString);
        }

        private void findTvDBSeries(string searchString)
        {
            List<Show> results = tvdb.Search(searchString, 5);
            if (results.Count != 0)
            {
                var dialog = new SelectMovie(results);
                string path = currentDir + "\\" + MovieBox.SelectedItem;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Process the stuff
                    Show tvSerie = dialog.getSelectedTVShow();
                    var webClient = new WebClient();
                    var file = path + "\\cover.jpg";
                    webClient.DownloadFile(tvSerie.Poster, file);
                    var writeXMl = new WriteTvInfoToXml(tvSerie, path);
                }

            }
            else if (results.Count == 0)
            {
                MessageBox.Show("Nothing found on TheTVDB");
            }
        }

        private void FindMovie(string searchString)
        {
            SearchContainer<SearchMovie> searchResults = client.SearchMovie(searchString);

            if (searchResults.TotalResults != 0)
            {
                var dialog = new SelectMovie(searchResults);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Process the stuff
                    SearchMovie selectedMovie = dialog.getSelectedItemMovie();
                    var movie = client.GetMovie(selectedMovie.Id, MovieMethods.Credits);
                    string path = currentDir + "\\" + MovieBox.SelectedItem;
                    var file = path + "\\cover.jpg";
                    var webClient = new WebClient();
                    webClient.DownloadFile("https://image.tmdb.org/t/p/original" + movie.PosterPath, file);
                    var temp = new WriteMovieInfoToXML(movie, path);
                }
            }
            else
            {
                MessageBox.Show("Nothing found on TheMovieDB");
            }

        }

        private string getUsableSearchString(string directory)
        {
            var regex1 = new Regex(@"\[[^\]]+\]");
            var regex2 = new Regex(@"\([^\]]+\)");
            var temp = regex1.Replace(directory, "");
            temp = regex2.Replace(temp, "");
            return Regex.Replace(temp, "[_.]", " ");
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchString = getUsableSearchString(MovieBox.SelectedItem + "");
            FindMovie(searchString);
        }

        private void ContextSearchTV_Click(object sender, EventArgs e)
        {
            string searchString = getUsableSearchString(MovieBox.SelectedItem + "");
            findTvDBSeries(searchString);
        }

        private void getInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folder = currentDir + "\\" + MovieBox.SelectedItem;
            var dialog = new Info_Window(folder);
            dialog.ShowDialog();
        }

        private void MovieBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = MovieBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches || index != 0)
            {
                String folder = currentDir + "\\" + MovieBox.SelectedItem;
                var content = Directory.GetFiles(folder, "*.nfo", SearchOption.TopDirectoryOnly);
                if (content.Length !=0)
                {
                    var dialog = new Info_Window(folder);
                    dialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This movie/serie does not contains a info file");
                }
            }
        }

        private void imageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSelection dialog = new ImageSelection();
            DialogResult res = dialog.ShowDialog();
            if(res == DialogResult.OK)
            {

                Settings.Default.ProfilePicturePath = dialog.getProfilePicture();
                Settings.Default.BackgroundPicturePath = dialog.getBackground();
                Settings.Default.Save(); // Saves settings in application configuration file
                string background = Settings.Default.BackgroundPicturePath;
                string profilepic = Settings.Default.ProfilePicturePath;
                baseDir = Settings.Default.baseDir;
                if (background != null)
                {
                    BackgroundImage = new Bitmap(background);
                    BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    BackgroundImage = null;
                }
                if (profilepic != null)
                {
                    profilePicture.Image = new Bitmap(profilepic);
                    profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    profilePicture.Image = null;
                }
            }
        }

        private void mainFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SelectMovieFolder();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.baseDir = dialog.GetSelectedFolder();
                baseDir = dialog.GetSelectedFolder();
                Settings.Default.Save();
            }

        }

        private void onResize(object sender, EventArgs e)
        {
            profilePicture.Location = new Point(Width - 164, 28);
        }

        private void MovieBox_MouseDown(object sender, MouseEventArgs e)
        {
            MovieBox.SelectedIndex = MovieBox.IndexFromPoint(e.X, e.Y);
        }
    }
}