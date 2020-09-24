using System;
using System.Collections.Generic;
using System.Text;

namespace Waterlog.Common.Interfaces
{
    public interface ICostItem
    {
        int Id { get; set; }
        string Description { get; set; }
        double PurchasePrice { get; set; }
        double MarketValue { get; set; }
        DateTime AcquisitionDate { get; set; }
    }
}
