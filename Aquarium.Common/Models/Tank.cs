using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Waterlog.Common.Interfaces;

namespace Waterlog.Common.Models
{
    public class Tank : ICostItem
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Size { get; set; }
        public DateTime AcquiredFrom { get; set; }
        public double PurchasePrice { get; set; }
        public double MarketValue { get; set; }
        public DateTime AcquisitionDate { get; set; }
    }
}
