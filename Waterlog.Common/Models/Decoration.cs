﻿using Waterlog.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Waterlog.Common.Models
{
    public class Decoration
    {
        [Key]
        public int Id { get; set; }

        public string DecorationName { get; set; }

        public int CostId { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(CostId))]
        public Cost CostInfo { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public Aquarium Aquarium { get; set; }
    }
}
