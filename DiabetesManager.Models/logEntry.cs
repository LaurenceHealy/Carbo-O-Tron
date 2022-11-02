using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DiabetesManager.Models
{
    public class logEntry
    {
        [Key]
        public int entryId { get; set; }
        [Required]
        [DisplayName("Date and Time")]
        public DateTime dateTime { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Blood Glucose")]
        public int entryBg { get; set; }
        [DisplayName("Carbohydrates")]
        public int entryCarb { get; set; }
        [DisplayName("Units of Insulin")]
        [Range(0, 10, ErrorMessage = "It is unsafe to deliver that much insulin!")]
        public double entryInsulin { get; set; }
        [DisplayName("Notes")]
        public string entryNote { get; set; }
    }
}
