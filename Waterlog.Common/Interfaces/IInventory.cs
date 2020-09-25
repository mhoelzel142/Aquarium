using System;
using System.Collections.Generic;
using System.Text;

namespace Waterlog.Common.Interfaces
{
    public interface IInventory
    {
        ICostItem Item { get; set; }
        bool Add();
        bool Remove();
    }
}
