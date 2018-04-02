using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letsCinema
{
    class Info
    {
        public List<Info> moviesInfo = new List<Info>();

        public int movieID;
        public string Name;
        public string VisionDate;
        public string IMDB_Point;
        public string Nationality;
        public string Company;
        public string TypeOfMovie;

        public Info(string _name, string _visiondate, string _imdbPoint , string _nationality , string _company,string _typeofmovie)
        {
            this.Name = _name;
            this.VisionDate = _visiondate;
            this.IMDB_Point = _imdbPoint;
            this.Nationality = _nationality;
            this.Company = _company;
            this.TypeOfMovie = _typeofmovie;
            moviesInfo.Add(this);
        }
    }
}
