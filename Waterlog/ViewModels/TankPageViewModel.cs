using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterlog.Common.Models;
using Waterlog.Database;
using Waterlog.Common.Extensions;

namespace Waterlog.ViewModels
{
    public class TankPageViewModel : ViewModelBase
    {
        public ObservableCollection<Aquarium> Aquaria { get; set; }
        private readonly SqliteReader reader;

        private Aquarium _SelectedAquarium { get; set; }
        public Aquarium SelectedAquarium
        {
            get => _SelectedAquarium;
            set
            {
                if (_SelectedAquarium != value)
                {
                    _SelectedAquarium = value;
                    OnPropertyChanged(nameof(SelectedAquarium));
                }
            }
        }

        private decimal _TotalValue { get; set; }
        public decimal TotalValue
        {
            get => _TotalValue;
            set
            {
                if (_TotalValue != value)
                {
                    _TotalValue = value;
                    OnPropertyChanged(nameof(TotalValue));
                }
            }
        }

        public TankPageViewModel(SqliteReader reader)
        {
            this.reader = reader;

            Aquaria = new ObservableCollection<Aquarium>();
            Aquaria.AddAll(reader.GetAll<Aquarium>().ToList());
            TotalValue = 150.54m;
        }


        public ObservableCollection<Equipment> Equipment = new ObservableCollection<Equipment>()
        {
            new Equipment()
            {
                Name = "Penn Plax Cascade 1000 Canister Filter",
                Description = "Canister filter",
                CostInfo = new Cost()
                {
                    PurchasePrice = 77.53
                }
            }
        };
    }
}
