using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class cinema
    {
        [Key]
        public int CinemaID { get; set; }

        public string Description { get; set; }
        
        public string Logo { get; set; }
     
        public string Name { get; set; }
        public List<movie> movies { get; set; }
        
    }
}
