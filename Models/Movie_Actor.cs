using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie_Actor
    {
       
        public int ActorId { get; set; }

        public actor actor { get; set; }
        public int MovieId { get; set; }


        public movie movie { get; set; }

    }
}
