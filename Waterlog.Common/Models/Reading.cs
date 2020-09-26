using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Waterlog.Common.Enums;
using static Waterlog.Common.Enums.ReadingTypeEnum;

namespace Waterlog.Common.Models
{
    public class Reading
    {
        [Key]
        public int Id { get; set; }

        public double ReadingValue { get; set; }

        public ReadingType ReadType { get; set; }

        public DateTime ReadDate { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public Aquarium Aquarium { get; set; }
    }
}
