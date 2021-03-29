using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingAPI.Model
{
    [Table("questions")]
    public class Questions
    {
        [Key]
        [Required]
        public int id { get; set; }

        public string question { get; set; }

        public string incorrect_answer1 { get; set; }
        public string incorrect_answer2 { get; set; }
        public string correct_answer { get; set; }
    }
}
