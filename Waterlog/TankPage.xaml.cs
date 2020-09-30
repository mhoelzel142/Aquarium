using Waterlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for TankPage.xaml
    /// </summary>
    public partial class TankPage : UserControl
    {
        private TankPageViewModel viewModel;
        public EquipmentPageViewModel epvm { get; set; }

        public TankPage()
        {
            InitializeComponent();
            // Parameterless ctor for designer
        }

        public TankPage(TankPageViewModel _viewModel)
        {
            viewModel = _viewModel;
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = new AddAquariumViewModel(new Database.SqliteContext());
            var w = new AddAquariumWindow(vm);
            w.Show();
        }
    }
}
