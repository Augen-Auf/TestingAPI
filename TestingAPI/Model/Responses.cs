using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestingAPI.Model
{
    [Table("responses")]
    public class Responses
    {
        [Key]
        [Required]
        public int id { get; set; }

        [ForeignKey("Users")]
        public int user_id { get; set; }
        public Users Users { get; set; }

        public string answers { get; set; }

        public string correct_questions { get; set; }

        public string incorrect_questions { get; set; }
    }
}
