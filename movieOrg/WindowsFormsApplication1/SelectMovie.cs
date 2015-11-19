using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TVDBSharp.Models;

namespace WindowsFormsApplication1
{
    public partial class SelectMovie : Form
    {
        private List<SearchMovie> movies;
        private List<Show> shows;
        private Boolean isMovie;

        public SelectMovie(SearchContainer<SearchMovie> movies)
        {
            this.isMovie = true;
            this.movies = movies.Results;
            InitializeComponent();
            foreach(SearchMovie movie in movies.Results)
            {
                if (movie.ReleaseDate != null)
                {
                    DateTime date = (DateTime)movie.ReleaseDate;
                    listBox1.Items.Add(movie.Title + " " + date.Year);
                }
                else
                {
                    listBox1.Items.Add(movie.Title + " Unknown Year");
                }
            }
        }

        public SelectMovie(List<Show> shows)
        {
            this.shows = shows;
            InitializeComponent();
            foreach (var show in shows)
            {
                if (show.FirstAired != null)
                {
                    DateTime date = (DateTime)show.FirstAired;
                    listBox1.Items.Add(show.Name + " " + date.Year);
                }
                else
                {
                    listBox1.Items.Add(show.Name + " Unknown Year");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public SearchMovie getSelectedItemMovie()
        {
            return movies[listBox1.SelectedIndex];
        }

        public Show getSelectedTVShow()
        {
            return shows[listBox1.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void seeOnTheWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            if (this.isMovie)
            {
                int id = movies[listBox1.SelectedIndex].Id;
                Process.Start("https://www.themoviedb.org/movie/" + id);
            }
            else
            {
                int id = shows[listBox1.SelectedIndex].Id;
                Process.Start("http://thetvdb.com/?tab=series&id=" + id);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
        }
    }
}
