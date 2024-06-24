using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class producers
    {
        [Key]
        public int ProducerId { get; set; }     
        public string ProfilePicUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<movie> movies { get; set; }
    }
}
