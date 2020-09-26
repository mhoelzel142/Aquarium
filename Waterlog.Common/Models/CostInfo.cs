using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Waterlog.Common.Interfaces;

namespace Waterlog.Common.Models
{
    public class Cost
    {
        [Key]
        public int Id { get; set; }

        public double PurchasePrice { get; set; }

        public double MarketValue { get; set; }

        public DateTime AcquisitionDate { get; set; }

        public int AcquisitionInfoId { get; set; }

        [ForeignKey(nameof(AcquisitionInfoId))]
        public AcquisitionInfo AcquiredFrom { get; set; }
    }
}
