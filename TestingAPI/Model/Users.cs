using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestingAPI.Model
{
    [Table("users")]
    public class Users
    {
        [Key]
        [Required]
        public int id { get; set; }

        public string fullName { get; set; }
    }
}
