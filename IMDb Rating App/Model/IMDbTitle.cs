using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace IMDb_Rating_App.Model
{
    public class IMDbTitle
    {
        public string Title { get; set; }
        public string Genres { get; set; }
        public string Plot { get; set; }
        public double Rating { get; set; }
        public int Metascore { get; set; }
        public string Poster { get; set; }
        public int Seasons { get; set; }
        public string Link { get; set; }
        public string Year { get; set; }
        public string Search { get; set; }
    }
}
