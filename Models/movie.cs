using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class movie
    {
        [Key]
        public int MovieId { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public double Price { get; set; } 
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MoviesCategory MoveiCategory { get; set; }    

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public cinema cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public producers producers { get; set; }
        public List<Movie_Actor> movie_Actors { get; set; }

    }
}
