using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Waterlog.Common.Extensions
{
    public static class ObservableCollectionExtensions
    {
        public static void AddAll<T>(this ObservableCollection<T> collection, IEnumerable<T> source) where T : class
        {
            if (source != null)
            {
                foreach (var item in source)
                {
                    collection.Add(item);
                }
            }
        }
    }
}
