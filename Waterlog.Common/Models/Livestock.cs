﻿using Waterlog.Common.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Waterlog.Common.Models
{
    public class Livestock
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Breed { get; set; }

        public int CostId { get; set; }

        public int AquariumId { get; set; }

        [ForeignKey(nameof(CostId))]
        public Cost CostInfo { get; set; }

        [ForeignKey(nameof(AquariumId))]
        public Aquarium Aquarium { get; set; }
    }
}