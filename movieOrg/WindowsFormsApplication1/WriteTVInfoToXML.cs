using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using TMDbLib.Objects.TvShows;
using TVDBSharp;
using TVDBSharp.Models;

namespace WindowsFormsApplication1
{
    public class WriteTvInfoToXml
    {
        private string _apiKey = "D006A38E5EF5852B";

        public WriteTvInfoToXml(Show tvShow, string folder)
        {
            var tvdb = new TVDB(_apiKey);
            var _episodeGuide = "http://www.thetvdb.com/api/" + _apiKey + "/series/" + tvShow.Id + "/all/en.zip";
            var actors = tvShow.Actors;
            string _year;
            if (tvShow.FirstAired != null)
            {
                _year = ((DateTime) tvShow.FirstAired).Year.ToString();
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
            using (XmlWriter writer = XmlWriter.Create(folder + "\\tvshow.nfo", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("tvshow");
                    writer.WriteElementString("title", tvShow.Name);
                    writer.WriteElementString("showtitle", tvShow.Name);
                    writer.WriteElementString("year", _year);
                    writer.WriteElementString("plot", tvShow.Description);
                    writer.WriteStartElement("episodeguideurl");
                        writer.WriteElementString("url", _episodeGuide);
                    writer.WriteEndElement();
                    foreach (var genre in tvShow.Genres)
                    {
                        writer.WriteElementString("genre", genre);
                    }
                    writer.WriteElementString("premiered", tvShow.FirstAired.ToString());
                    foreach (var actor in actors)
                    {
                        writer.WriteStartElement("actor");
                            writer.WriteElementString("name", actor);
                        writer.WriteEndElement();
                    }
                    writer.WriteElementString("dateadded", DateTime.Now.ToString());
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}