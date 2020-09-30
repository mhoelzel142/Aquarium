using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterlog.Common.Models;
using Waterlog.Database;

namespace Waterlog.ViewModels
{
    public class EquipmentPageViewModel : ViewModelBase
    {
        private SqliteContext context;

        private Aquarium _SelectedAquarium { get; set; }
        public Aquarium SelectedAquarium
        {
            get => _SelectedAquarium;
            set
            {
                _SelectedAquarium = value;
                OnPropertyChanged(nameof(SelectedAquarium));
            }
        }

        public EquipmentPageViewModel(SqliteContext _context)
        {
            context = _context;
        }
    }
}
