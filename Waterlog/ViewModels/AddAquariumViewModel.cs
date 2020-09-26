using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterlog.Common.Models;
using Waterlog.Database;

namespace Waterlog.ViewModels
{
    public class AddAquariumViewModel : ViewModelBase
    {
        private Aquarium _Aquarium { get; set; }
        public Aquarium Aquarium
        {
            get => _Aquarium;
            set
            {
                if (_Aquarium != value)
                {
                    _Aquarium = value;
                    OnPropertyChanged(nameof(Aquarium));
                }
            }
        }

        private SqliteContext context;

        public AddAquariumViewModel(SqliteContext _context)
        {
            context = _context;
            Aquarium = new Aquarium();
        }

        internal void SaveAquarium()
        {
            context.Set<Aquarium>().Add(Aquarium);
            context.SaveChanges();
        }
    }
}
