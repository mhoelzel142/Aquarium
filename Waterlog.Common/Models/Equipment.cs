using Waterlog.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class Equipment : ICostItem
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double PurchasePrice { get; set; }
        public double MarketValue { get; set; }
        public DateTime AcquisitionDate { get; set; }
    }
}
