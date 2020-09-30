using System;
using Waterlog.Common.Models;
using Waterlog.Database;

namespace Waterlog.ViewModels
{
    public class AddEquipmentViewModel : ViewModelBase
    {
        public Equipment Equipment { get; set; }
        public SqliteContext context = new SqliteContext();

        public AddEquipmentViewModel()
        {
            Equipment = new Equipment();
        }


    }
}