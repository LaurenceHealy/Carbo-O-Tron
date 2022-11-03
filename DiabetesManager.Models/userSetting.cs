using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.Models
{
    public class userSetting
    {
        [Key]
        public int settingId { get; set; }

        [Required]
        [DisplayName("Target Blood Glucose Level")]
        public int targetBgl { get; set; }

        [Required]
        [DisplayName("Low Blood Glucose Alert Level")]
        public int lowBglAlert { get; set; }

        [Required]
        [DisplayName("Insulin Correction Factor")]
        public int insulinCorrectionFactor { get; set; }

        [Required]
        [DisplayName("Carbohydrate Ratio")]
        public int carbRatio { get; set; }

        [DisplayName("Insulin Action Time")]
        public int insulinActionTime { get; set; }
    }
}
