using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Movie
    {

        public int Id { get; set; }
        //the movieID from TMDB
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string TagLine { get; set; }
        public string Overview { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public byte[] Poster { get; set; }
        public string ContentType { get; set; }

        [Display(Name = "Background Image")]
        public byte[] BGImage { get; set; }
        public string BGContentType { get; set; }

        //Public URL of the trailer
        [Display(Name = "Trailer URL")]
        public string Trailer { get; set; }

        public ICollection<Cast> CAst { get; set; } = new HashSet<Cast>();

    }
}
