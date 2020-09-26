using Waterlog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Waterlog.Common.Models;

namespace Waterlog.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly SqliteReader reader;
        private TankPageViewModel _TankPageViewModel;

        public static ObservableCollection<Aquarium> Aquaria = new ObservableCollection<Aquarium>();

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
            Initialize();
        }

        private void Initialize()
        {
            foreach (var tank in GetTanks())
            {
                Aquaria.Add(tank);
            }
        }

        private List<Aquarium> GetTanks()
        {
            return reader.GetAll<Aquarium>().ToList();
        }
    }
}