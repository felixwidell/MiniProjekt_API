using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniProjekt_API.Models
{
    public class RelationTable
    {
        [Key]
        public int RelationID { get; set; } 
        public virtual int FK_User { get; set; }
        public virtual int FK_Interest { get; set; }
    }
}
