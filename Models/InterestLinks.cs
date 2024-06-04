using System.ComponentModel.DataAnnotations;

namespace MiniProjekt_API.Models
{
    public class InterestLinks
    {
        [Key]
        public int LinkID { get; set; }
        public string LinkUrl { get; set; }
        public virtual int FK_InterestLinks_Interests { get; set; }
    }
}
