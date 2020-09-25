using Waterlog.Common.Interfaces;
using System;

namespace Waterlog.Common.Models
{
    public class Livestock : ICostItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public string AcquiredFrom { get; set; }
        public double PurchasePrice { get; set; }
        public double MarketValue { get; set; }
        public DateTime AcquisitionDate { get; set; }
    }
}
