using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TVDBSharp;
using TVDBSharp.Models;

namespace WindowsFormsApplication1
{
    class WriteMovieInfoToXML
    {
        public WriteMovieInfoToXML(Movie movie, string folder)
        {
            TMDbClient client = new TMDbClient("a8fab4f9461636422a8df05bf17065a8");
            var actors = movie.Credits.Cast;
            var crews = movie.Credits.Crew;
            string _year;

            string[] files = Directory.GetFiles(folder, "*", SearchOption.TopDirectoryOnly);
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
            string nfile = null;
            if (videoFiles.Count == 1)
            {
                int index = videoFiles[0].LastIndexOf("\\");
                nfile = videoFiles[0].Substring(index + 1);
                Console.WriteLine(nfile);
            }
            
            if (movie.ReleaseDate != null)
            {
                _year = ((DateTime)movie.ReleaseDate).Year.ToString();
            }
            else
            {
                _year = "Unkown year";
            }
            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                NewLineOnAttributes = true
            };
            using (XmlWriter writer = XmlWriter.Create(folder + "\\"+ nfile.Substring(0,nfile.Length-4) + ".nfo", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("movie");
                writer.WriteElementString("title", movie.Title);
                writer.WriteElementString("originaltitle", movie.OriginalTitle);
                writer.WriteElementString("rating", movie.VoteAverage.ToString());
                writer.WriteElementString("votes", movie.VoteCount.ToString());
                writer.WriteElementString("year", _year);
                writer.WriteElementString("plot", movie.Overview);
                writer.WriteElementString("tagline", movie.Tagline);
                writer.WriteElementString("runtime", movie.Runtime.ToString());
                writer.WriteElementString("thumb", "https://image.tmdb.org/t/p/original" + movie.PosterPath);
                writer.WriteElementString("filenameandpath", folder + "\\" + nfile);
                foreach (var genre in movie.Genres)
                {
                    writer.WriteElementString("genre", genre.Name);
                }
                foreach (var actor in actors)
                {
                    writer.WriteStartElement("actor");
                    writer.WriteElementString("name", actor.Name);
                    writer.WriteElementString("role", actor.Character);
                    writer.WriteEndElement();
                }
                foreach (var crew in crews)
                {
                    writer.WriteStartElement("crew");
                    writer.WriteElementString("name", crew.Name);
                    writer.WriteElementString("job", crew.Job);
                    writer.WriteEndElement();
                }
                writer.WriteElementString("dateadded", DateTime.Now.ToString());
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
