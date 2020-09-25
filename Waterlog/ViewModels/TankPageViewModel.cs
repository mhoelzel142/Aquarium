using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterlog.Common.Models;
using Waterlog.Database;

namespace Waterlog.ViewModels
{
    public class TankPageViewModel : ViewModelBase
    {
        public ObservableCollection<Aquarium> Aquaria { get; set; }
        private readonly SqliteReader reader;

        private string _Title = "This is the title";
        public string Title
        {
            get => _Title;
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public TankPageViewModel(SqliteReader reader)
        {
            this.reader = reader;
        }
    }
}
