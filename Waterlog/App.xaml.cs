using Waterlog.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Waterlog.ViewModels;

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // dependency injection, class needs these things later
            var reader = new SqliteReader();
            var vm = new MainWindowViewModel(reader);

            this.MainWindow = new MainWindow(vm);
            MainWindow.Show();
        }
    }
}
