using System.ComponentModel.DataAnnotations;

namespace MiniProjekt_API.Models
{
    public class Interests
    {
        public string InterestName { get; set; }
        public string InterestDescription { get; set;}
        [Key]
        public int InterestID { get; set; }
    }
}
