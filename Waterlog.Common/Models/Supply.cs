using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Waterlog.Common.Models
{
    /// <summary>
    /// Supplies purchased or acquired for the Aquarium, including chemicals, filter media, medications, and more. 
    /// </summary>
    public class Supply
    {
        [Key]
        public int Id { get; set; }

        public int CostId { get; set; }

        [ForeignKey(nameof(CostId))]
        public Cost CostInfo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
