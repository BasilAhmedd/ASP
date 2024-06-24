using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class actor
    {
        [Key]
        public int ActorID { get; set; }
        [Required]
        public string FullName { get; set; }

        public string ProfilePicUrl { get; set; }
        public string Bio { get; set; }

        public List<Movie_Actor> movie_Actors { get; set; }
    }
}
