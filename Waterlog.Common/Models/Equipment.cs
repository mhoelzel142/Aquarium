using Waterlog.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Waterlog.Common.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        public int CostInfoId { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(CostInfoId))]
        public Cost CostInfo { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public Aquarium Aquarium { get; set; }
    }
}
