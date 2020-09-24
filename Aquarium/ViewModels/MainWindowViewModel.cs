using Waterlog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterlog.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly SqliteReader reader;
        private TankPageViewModel _TankPageViewModel;
        public TankPageViewModel tpvm
        {
            get => _TankPageViewModel;
            set
            {
                if (_TankPageViewModel != value)
                {
                    _TankPageViewModel = value;
                    OnPropertyChanged(nameof(tpvm));
                }
            }
        }

        public MainWindowViewModel(SqliteReader _reader)
        {
            reader = _reader;
            tpvm = new TankPageViewModel(_reader);
        }

    }
}
