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

        public string Name { get; set; }

        public string Description { get; set; }

        public int CostInfoId { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(CostInfoId))]
        public virtual Cost CostInfo { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public virtual Aquarium Aquarium { get; set; }
    }
}
