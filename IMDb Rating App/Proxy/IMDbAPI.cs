using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace IMDb_Rating_App.Model
{
    public class IMDbAPI
    {
        private const string IMDB_URL = "http://www.imdb.com/find?q=";

        public IMDbTitle loadTitle(string titleName)
        {
            WebClient client = new WebClient();
            string resultsPage = client.DownloadString(IMDB_URL + titleName);

            Regex titleMatchEx = new Regex("<td class=\"result_text\"> <a href=\"(/title/tt(\\d){1,20})");
            string imdbTitleLink = titleMatchEx.Match(resultsPage).Groups[1].Value;
            string titleLink = "http://www.imdb.com" + imdbTitleLink;
            string moviePage = client.DownloadString(titleLink);

            IMDbTitle title = new IMDbTitle();

            title.Link = titleLink;

            if (string.IsNullOrEmpty(imdbTitleLink))
                title.Title = titleName;
            else
                title.Title = new Regex("<span class=\"itemprop\" itemprop=\"name\">(.*)</span>").Match(moviePage).Groups[1].Value;

            title.Seasons = new Regex("season=\\d*&").Matches(moviePage).Count;

            string metascore = new Regex("Metascore: <.*\\n.*>.*?(\\d*)\\/").Match(moviePage).Groups[1].Value;
            int metascoreDbl = 0;

            if (!string.IsNullOrEmpty(metascore) && !string.IsNullOrWhiteSpace(metascore))
                metascoreDbl = int.Parse(metascore);

            title.Metascore = metascoreDbl;

            string rating = new Regex("<span itemprop=\"ratingValue\">(\\d.\\d)</span>").Match(moviePage).Groups[1].Value;
            double ratingDbl = 0;

            if (!string.IsNullOrEmpty(rating))
                ratingDbl = double.Parse(rating, CultureInfo.InvariantCulture);

            title.Rating = ratingDbl;
            title.Year = new Regex("<title>.*\\((.*)\\).*</title>").Match(moviePage).Groups[1].Value.Replace("â€“", "-");
            title.Poster = new Regex("<link rel='image_src' href=\"(http://ia.media-imdb.com/images/M/.*)\">").Match(moviePage).Groups[1].Value;

            title.Genres = "";

            foreach (Match match in new Regex("<span class=\"itemprop\" itemprop=\"genre\">(.*)</span>").Matches(moviePage))
                title.Genres += match.Groups[1].Value + ", ";

            if (title.Genres.Length > 0)
                title.Genres = title.Genres.Remove(title.Genres.Length - 2);

            title.Plot = new Regex("<p itemprop=\"description\">\\n(.*)\\.\\.\\.").Match(moviePage).Groups[1].Value;

            if (string.IsNullOrEmpty(title.Plot))
                title.Plot = new Regex("<p itemprop=\"description\">\\n(.*)</p>").Match(moviePage).Groups[1].Value;
            else
                title.Plot += "...";

            title.Search = titleName;

            return title;
        }
    }


}
