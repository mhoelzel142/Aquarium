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
    public class TankPageViewModel
    {
        public ObservableCollection<Aquarium> Aquaria { get; set; }
        private readonly SqliteReader reader;

        public string title = "THIS IS THE TITLE"; // DI test, passing context to user control via XAML binding

        public TankPageViewModel(SqliteReader reader)
        {
            this.reader = reader;
        }
    }
}
