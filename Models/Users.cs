using System.ComponentModel.DataAnnotations;

namespace MiniProjekt_API.Models
{
    public class Users
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phonenumber { get; set; }
        [Key]
        public int UserID { get; set; }
    }
}
