using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Waterlog.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Waterlog.Common.Models
{
    public class Tank
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public double Size { get; set; }

        public int CostId { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(CostId))]
        public Cost CostInfo { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public Aquarium Aquarium { get; set; }
    }
}
